/**
 * @param {string} pattern
 * @param {string} s
 * @return {boolean}
 */
const wordPattern = function (pattern, s) {
    const split = s.split(" ");
    if (pattern.length !== split.length) return false;

    const patternMap = new Map();
    const valueSet = new Set();

    for (let i = 0; i < pattern.length; i++) {
        const currentKey = pattern[i];
        const currentValue = split[i];
        const mappedValue = patternMap.get(currentKey);

        if (mappedValue === currentValue) continue;
        if (mappedValue && mappedValue !== currentValue) return false;
        if (!mappedValue && valueSet.has(currentValue)) return false;

        patternMap.set(currentKey, currentValue);
        valueSet.add(currentValue);
    }

    return true;
};

module.exports = {
    wordPattern: wordPattern
};