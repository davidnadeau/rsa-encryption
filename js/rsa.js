var RSA = (function() {

var BLOCKSIZE = 3;

function gcd(n,m) {
    var p = n > m ? n : m;
    var q = n < m ? n : m;
    var r = p % q;

    while (r > 0) {
        p = q;
        q = r;
        r = p % q;
    }
    return q;
}

function splitMessage(msg) {
    var blocks = [];
    for (var i = 0; i < msg.length; i += BLOCKSIZE)
        blocks.push(msg.substring(i, i + BLOCKSIZE));
    return blocks;
}

function encrypt(msg, e, n) {
    blocks = splitMessage(msg, BLOCKSIZE);
    msg = [];
    for (var i = 0; i < blocks.length; ++i)
        msg.push(exp(+blocks[i], e, n));
    return msg; 
}

function decrypt(blocks, d, n) {
    var msg = "";
    for (var i = 0; i < blocks.length; ++i) {
        decoded = exp(blocks[i], d, n)
        if (decoded < Math.pow(10,BLOCKSIZE-1))
            decoded = '0' + decoded;       
        msg += decoded;
    }
    return msg; 
}

function findD(n, e) {
    var i = 0;
    while (i++ < n)
        if ((i*e)%n === 1)
            return i;
    return -1;
}

function findE(n, phin) {
    var i = 0;
    while (Math.pow(2,i) < n) ++i;
    while (i++ < phin) 
        if (gcd(i, phin) == 1)
        return i;
    return -1;
}

function exp(x,y,n) {
    var result = 1;
    for (var i = 0; i < y; ++i)
       result = (result * x) % n;
    return result;
}

function isPrime(n) {
    if (n < 2) return false;
    if (n === 2 || n === 3) return true;
    if (n % 2 === 0 || n % 3 === 0) return false;
    var largestDivisor = Math.round(Math.sqrt(n));
    for (var i = 5; i <= largestDivisor; i+=6) {
        if (n % i === 0 || n % (i + 2) === 0) return false;
    }
    return true;
}
function generatePrime(length) {
    var x = randomRange(Math.pow(10,length-1), Math.pow(10,length));
    while (x < Math.pow(10, length)) {
        if (isPrime(x))
            return x;
        ++x;
    }
    return 107;
}

function randomRange(min, max) {
    return min + Math.round((Math.random()*(max-min)));
}

function encode(msg) {
    var encoded = "";
    var block;

    for (var i = 0; i < msg.length; ++i) {
        block = msg.charCodeAt(i);
        if (block < Math.pow(10, BLOCKSIZE - 1))
            block = "0"+block;
        encoded += block;
    }
    return encoded;
}

function decode(msg) {
    var encoded = "";
    var block;

    for (var i = 0; i < msg.length; i+=BLOCKSIZE) {
        block = "";
        for (var j = 0; j < BLOCKSIZE; ++j)
            block += msg.charAt(i+j);
        encoded += String.fromCharCode(block);
    }
    return encoded;
}

return {
    test: function() {
        var p = generatePrime(3);
        var q = generatePrime(3);
        var n = p*q;
        
        var phin = (p-1)*(q-1);
        var e = findE(n, phin);
        var d = findD(phin, e);
        
        var plaintext = "HEY ther !@$^*(*( EF EF*E( Fjij..// ) ))";
        var encoded =   encode(plaintext);
        var encrypted = encrypt(encoded, e, n);
        var decrypted = decrypt(encrypted, d, n);
        var decoded =   decode(decrypted);
        
        console.log("Input :", plaintext);
        console.log("Encoded :", encoded);
        console.log("Encrypted :", encrypted);
        console.log("Decrypted :", decrypted);
        console.log("Output :", decoded);
    }
};
}());
RSA.test();
