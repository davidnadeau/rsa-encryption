var RSA = (function() {

function Gcd(n,m) {
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

function encode(msg, e, n, BLOCKSIZE) {
    blocks = splitMessage(msg, BLOCKSIZE);
    msg = [];
    for (var i = 0; i < blocks.length; ++i)
        msg.push(exp(+blocks[i], e, n));
    return msg; 
}

function decode(blocks, d, n) {
    var msg = "";
    for (var i = 0; i < blocks.length; ++i)
        msg += exp(+blocks[i], d,n);
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
        if (Gcd(i, phin) == 1)
        return i;
    return -1;
}

function exp(x,y,n) {
    var result = 1;
    for (var i = 0; i < y; ++i)
       result = (result * x) % n;
    return result;
}
return {
    test: function() {
        var BLOCKSIZE = 2;
        var p = 23;
        var q = 41;
        var n = p*q;
        var phin = (p-1)*(q-1);
        var e = findE(n, phin);
        var d = findD(phin, e);

        console.log("p:",p, "q:", q, "n:", n);
        console.log("phi:",phin);
        console.log("e:", e, "d:",d);
        var msg = "14152716181502120513";
        var cipher = encode(msg, e, n, BLOCKSIZE);
        var decoded  = decode(cipher, d, n, BLOCKSIZE);
        console.log("original: ", msg,'\n', "encrypted: ", cipher, '\n', "decoded: ", decoded); 
    }
};
}());
RSA.test();
