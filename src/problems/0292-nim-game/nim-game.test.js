const nimGame = require("./nim-game");
describe("Nim Game", () => {

    const cases = [
        {n: 1, expected: true},
        {n: 2, expected: true},
        {n: 3, expected: true},
        {n: 4, expected: false},
        {n: 5, expected: true},
        {n: 6, expected: true},
        {n: 7, expected: true},
        {n: 8, expected: false},
        {n: 9, expected: true},
        {n: 10, expected: true},
        {n: 11, expected: true},
        {n: 12, expected: false},
        {n: 13, expected: true},
        {n: 14, expected: true},
        {n: 15, expected: true},
        {n: 16, expected: false},
    ];

    it.each(cases)(`canWinNim should return $expected since there are $n stones`,
        async ({n, expected}) => {
            // arrange
            // act
            const result = nimGame.canWinNim(n);

            // assert
            expect(result).toBe(expected);
        });
});
