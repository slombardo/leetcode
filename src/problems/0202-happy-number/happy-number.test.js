const isHappy = require("./happy-number");

describe("isHappy", () => {
    const cases = [
        {
            n: 19,
            expected: true
        },
        {
            n: 2,
            expected: false
        },
    ];

    cases.forEach(test => {
        it(`isHappy should return should return ${test.expected}, indicating if n is happy`,
            () => {
                // arrange
                // act
                const result = isHappy.isHappy(test.n);

                // assert
                expect(result).toEqual(test.expected);
            });
    });
});
