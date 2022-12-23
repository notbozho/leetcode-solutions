function stringMatching(words: string[]): string[] {
    const substrings: string[] = [];

    words.forEach((word, i) => {
        words.forEach((secondWord, j) => {
            if (i != j && secondWord.includes(word) && !substrings.includes(word)) substrings.push(word);
        })
    })

    return substrings;
};