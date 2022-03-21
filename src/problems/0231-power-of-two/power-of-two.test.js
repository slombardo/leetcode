const powerOfTwo = require("./power-of-two");

describe("isPowerOfTwo", () => {
    const cases = [
        {
            n: 1,
            expected: true
        },
        {
            n: 16,
            expected: true
        },
        {
            n: 3,
            expected: false
        },
        {
            n: -2147483648,
            expected: false
        },
    ];

    cases.forEach(test => {
        it(`checkOnesInBinaryUsingToString should return ${test.expected}, indicating if ${test.n} is a power of 2`,
            () => {
                // arrange
                // act
                const result = powerOfTwo.checkOnesInBinaryUsingToString(test.n);

                // assert
                expect(result).toEqual(test.expected);
            });

        it(`checkForMoreThanOneOneWhileLooping should return ${test.expected}, indicating if ${test.n} is a power of 2`,
            () => {
                // arrange
                // act
                const result = powerOfTwo.checkForMoreThanOneOneWhileLooping(test.n);

                // assert
                expect(result).toEqual(test.expected);
            });
    });
});
