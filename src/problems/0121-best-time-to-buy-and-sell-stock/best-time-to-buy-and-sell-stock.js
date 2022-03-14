/**
 * @param {number[]} prices
 * @return {number}
 */
const bruteForce = function (prices) {
    let biggestProfit = 0;
    for (let i = 0; i < prices.length; i++) {
        const currentBuying = prices[i];
        let currentHighest = 0;

        currentHighest = Math.max(...prices.slice(i + 1, prices.length));
        biggestProfit = Math.max(biggestProfit, currentHighest - currentBuying);
    }

    return biggestProfit;
}

/**
 * @param {number[]} prices
 * @return {number}
 */
const lessRuns = function (prices) {
    let largestProfit = 0;
    let previousLargestIndex = 0;
    let previousLargest = 0;

    for (let i = 0; i < prices.length; i++) {
        let currentBuying = prices[i];
        let currentLargest = 0;
        //see if we already know the next largest number
        if (i < previousLargestIndex) {
            // since we know what the next largest is, just calculate and move on
            largestProfit = Math.max(largestProfit, previousLargest - currentBuying);
            continue;
        }

        for (let j = i + 1; j < prices.length; j++) {
            const next = prices[j];

            // if the this price is less than the last one, set index here
            if (j === i + 1 && next < currentBuying) {
                i = j;
                currentBuying = next;
                continue;
            }

            if (next > currentLargest) {
                previousLargestIndex = j;
                previousLargest = next
                currentLargest = next;
            }
        }
        largestProfit = Math.max(largestProfit, currentLargest - currentBuying);
    }

    return largestProfit;
}

/**
 * @param {number[]} prices
 * @return {number}
 */
const oneRun = function (prices) {
    let largestProfit = 0;
    let currentLargest = 0;
    let currentLowest = Number.MAX_VALUE;

    for (let i = 0; i < prices.length; i++) {
        let currentBuying = prices[i];

        // anytime the lowest changes, calculate then reset the largest
        if (currentBuying < currentLowest) {
            largestProfit = Math.max(largestProfit, currentLargest - currentLowest);
            currentLargest = currentBuying;
            currentLowest = currentBuying;
        }

        if (currentBuying > currentLargest) {
            currentLargest = currentBuying;
        }
    }
    largestProfit = Math.max(largestProfit, currentLargest - currentLowest);

    return largestProfit;
}

/*
    Added for speed testing Kadane's Algorithm using Math.max()
    Source:
    https://github.com/superkarn/leetcode/blob/master/src/problems/00100/121.%20Best%20Time%20to%20Buy%20and%20Sell%20Stock.js#L55-L66
 */

/**
 * @param {number[]} prices
 * @return {number}
 */
const kadanesAlgorithm = function (prices) {
    let bestPriceSoFar = 0;
    let currentBestPrice = 0;

    for (let i = 1; i < prices.length; i++) {
        currentBestPrice = Math.max(0, currentBestPrice + (prices[i] - prices[i - 1]));
        bestPriceSoFar = Math.max(bestPriceSoFar, currentBestPrice);
    }

    return bestPriceSoFar;
};

/*
    Added for speed testing Kadane's Algorithm without using Math.max()
    Source:
    https://github.com/troygizzi/leetcode/blob/master/121%20best-time-to-buy-and-sell-stock.mjs
 */

/**
 * @param {number[]} prices
 * @return {number}
 */
const kadanesAlgorithmLessAssignments = function (prices) {

    const enableLogging = false;
    if (enableLogging) console.log(`prices: ${JSON.stringify(prices)}`);

    let gain = 0;
    let maxGain = 0;
    let priceAtPurchase = prices[0];

    for (let i = 1; i < prices.length; i++) {
        const priceToday = prices[i];
        gain = priceToday - priceAtPurchase;
        if (enableLogging) console.log(`i: ${i}; priceAtPurchase: ${priceAtPurchase}; priceToday: ${priceToday}; gain: ${gain}`);

        if (gain > maxGain) {
            maxGain = gain;
            if (enableLogging) console.log(`  new maxGain: ${maxGain}`);
        } else if (gain < 0) {
            priceAtPurchase = priceToday;
            if (enableLogging) console.log(`  reset priceAtPurchase to ${priceAtPurchase}`);
        }
    }

    return maxGain;
};

module.exports = {
    bruteForce: bruteForce,
    lessRuns: lessRuns,
    oneRun: oneRun,
    kadanesAlgorithm: kadanesAlgorithm,
    kadanesAlgorithmLessAssignments: kadanesAlgorithmLessAssignments
};