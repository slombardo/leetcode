const moveZeros = require("./move-zeroes");
describe("Move Zeros", () => {

    const cases = [
        {nums: [0,1,0,3,12], expected: [1,3,12,0,0]},
        {nums: [0], expected: [0]},
    ];

    it.each(cases)(`onePass should modify $nums to be $expected`,
        async ({nums, expected}) => {
            // arrange
            // act
            moveZeros.onePass(nums);

            // assert
            expect(nums).toEqual(expected);
        });
});
