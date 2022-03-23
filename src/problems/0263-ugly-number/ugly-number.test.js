const uglyNumber = require("./ugly-number");
describe("isPowerOfTwo", () => {
    const cases = [
        {n: 1, expected: true},
        {n: 4, expected: true},
        {n: 6, expected: true},
        {n: 7, expected: false},
        {n: 8, expected: true},
        {n: 9, expected: true},
        {n: 10, expected: true},
        {n: 12, expected: true},
        {n: 14, expected: false},
        {n: 15, expected: true},
        {n: 20, expected: true},
        {n: 21, expected: false},
        {n: -2147483648, expected: false},
        {n: 937351770, expected: false},
    ];

    it.each(cases)(`bruteForce should return $expected, indicating if $n is an ugly number or not`,
        async ({n, expected}) => {
            // arrange
            // act
            const result = uglyNumber.bruteForce(n);

            // assert
            expect(result).toEqual(expected);
        }, 2000);

    // spins but never times out.  Related Jest issue: https://github.com/facebook/jest/issues/6947#issuecomment-1076672502
    it.each(cases)(`wayTooBruteForce should return $expected indicating if $n is an ugly number or not`,
        async ({n, expected}) => {
            // arrange
            // act
            const result = uglyNumber.wayTooBruteForce(n);

            // assert
            expect(result).toEqual(expected);
        }, 2000);

    // spins but never times out.  Related Jest issue: https://github.com/facebook/jest/issues/6947#issuecomment-1076672502
    it.each(cases)(`primeShortcuts should return $expected, indicating if $n is an ugly number or not`,
        async ({n, expected}) => {
            // arrange
            // act
            const result = uglyNumber.primeShortcuts(n);

            // assert
            expect(result).toEqual(expected);
        }, 2000);
});
