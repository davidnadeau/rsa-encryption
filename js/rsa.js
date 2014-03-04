var RSA = (function() {

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

function splitMessage(msg, BLOCKSIZE) {
    var blocks = [];
    for (var i = 0; i < msg.length; i += BLOCKSIZE)
        blocks.push(msg.substring(i, i + BLOCKSIZE));
    return blocks;
}

function encrypt(msg, e, n, BLOCKSIZE) {
    blocks = splitMessage(msg, BLOCKSIZE);
    msg = [];
    for (var i = 0; i < blocks.length; ++i)
        msg.push(exp(+blocks[i], e, n));
    return msg; 
}

function decrypt(blocks, d, n, BLOCKSIZE) {
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
    for (var i = 0; i < msg.length; i++) {
        encoded += encodeInput(msg.charAt(i));
    }
    return encoded;
}

function encodeInput(letter) {
    switch (letter) {
        case 'a': return "01";
        case 'b': return "02";
        case 'c': return "03";
        case 'd': return "04";
        case 'e': return "05";
        case 'f': return "06";
        case 'g': return "07";
        case 'h': return "08";
        case 'i': return "09";
        case 'j': return "10";
        case 'k': return "11";
        case 'l': return "12";
        case 'm': return "13";
        case 'n': return "14";
        case 'o': return "15";
        case 'p': return "16";
        case 'q': return "17";
        case 'r': return "18";
        case 's': return "19";
        case 't': return "20";
        case 'u': return "21";
        case 'v': return "22";
        case 'w': return "23";
        case 'x': return "24";
        case 'y': return "25";
        case 'z': return "26";
        case ' ': return "27";
    }
}

function decode(msg) {
    var encoded = "";
    for (var i = 0; i < msg.length; i+=2) {
        encoded += decodeInput(msg.charAt(i)+msg.charAt(i+1));
    }
    return encoded;
}

function decodeInput(num) {
    switch (+num) {
        case 1: return 'a';
        case 2: return 'b';
        case 3: return 'c';
        case 4: return 'd';
        case 5: return 'e';
        case 6: return 'f';
        case 7: return 'g';
        case 8: return 'h';
        case 9: return 'i';
        case 10: return 'j';
        case 11: return 'k';
        case 12: return 'l';
        case 13: return 'm';
        case 14: return 'n';
        case 15: return 'o';
        case 16: return 'p';
        case 17: return 'q';
        case 18: return 'r';
        case 19: return 's';
        case 20: return 't';
        case 21: return 'u';
        case 22: return 'v';
        case 23: return 'w';
        case 24: return 'x';
        case 25: return 'y';
        case 26: return 'z';
        case 27: return ' ';
    }
}
return {
    test: function() {
        var BLOCKSIZE = 2;
        var p = generatePrime(3);
        var q = generatePrime(3);
        var n = p*q;
        
        var phin = (p-1)*(q-1);
        var e = findE(n, phin);
        var d = findD(phin, e);
        
        var plaintext = "no problem";
        var encoded =   encode(plaintext);
        var encrypted = encrypt(encoded, e, n, BLOCKSIZE);
        var decrypted = decrypt(encrypted, d, n, BLOCKSIZE);
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
