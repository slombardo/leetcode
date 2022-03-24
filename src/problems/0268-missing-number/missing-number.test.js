const missingNumber = require("./missing-number");
describe("Missing Number", () => {

    const cases = [
        {n: [3,0,1], expected: 2},
        {n: [0,1], expected: 2},
        {n: [9,6,4,2,3,5,7,0,1], expected: 8},

    ];

    it.each(cases)(`bruteForce should return $expected, since it is missing from $n`,
        async ({n, expected}) => {
            // arrange
            // act
            const result = missingNumber.bruteForce(n);

            // assert
            expect(result).toEqual(expected);
        });

});
