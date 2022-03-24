const firstBadVersion = require("./first-bad-version");
describe("First Bad Version", () => {

    const cases = [
        {n: 5, bad: 4, expected: 4},
        {n: 1, bad: 1, expected: 1},
    ];

    it.each(cases)(`bruteForce should return $expected, since it is missing from $n`,
        async ({n, bad, expected}) => {
            // arrange
            const isBadVersion = (version) => version >= bad;
            // act
            const result = firstBadVersion.binarySearch(isBadVersion)(n);

            // assert
            expect(result).toEqual(expected);
        });

});
