const moveZeros = require("./word-pattern");
describe("Word Pattern", () => {

    const cases = [
        {pattern: "abba", s: "dog cat cat dog", expected: true},
        {pattern: "abba", s: "dog cat cat fish", expected: false},
        {pattern: "abba", s: "dog dog dog dog", expected: false},
        {pattern: "abbc", s: "dog cat cat fish", expected: true},
        {pattern: "aaaa", s: "dog cat cat dog", expected: false},
        {pattern: "aaaa", s: "dog dog dog dog", expected: true},
        {pattern: "aaa", s: "aa aa aa aa", expected: false},
    ];

    it.each(cases)(`wordPattern should determine that $s follows $pattern is $expected`,
        async ({pattern, s, expected}) => {
            // arrange
            // act
            const result = moveZeros.wordPattern(pattern, s);

            // assert
            expect(result).toBe(expected);
        });
});
