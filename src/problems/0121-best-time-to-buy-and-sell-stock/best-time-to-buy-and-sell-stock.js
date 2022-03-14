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
        if(i < previousLargestIndex){
            // since we know what the next largest is, just calculate and move on
            largestProfit = Math.max(largestProfit, previousLargest - currentBuying);
            continue;
        }

        for (let j = i+1; j < prices.length; j++) {
            const next = prices[j];

            // if the this price is less than the last one, set index here
            if(j === i+1 && next < currentBuying){
                i = j;
                currentBuying = next;
                continue;
            }

            if(next > currentLargest) {
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
        if(currentBuying < currentLowest)
        {
            largestProfit = Math.max(largestProfit, currentLargest - currentLowest);
            currentLargest = currentBuying;
            currentLowest = currentBuying;
        }

        if(currentBuying > currentLargest)
        {
            currentLargest = currentBuying;
        }
    }
    largestProfit = Math.max(largestProfit, currentLargest - currentLowest);

    return largestProfit;
}

module.exports = {
    bruteForce: bruteForce,
    lessRuns: lessRuns,
    oneRun: oneRun
};