function daysBetweenDates(date1: string, date2: string): number {
    const date1Ms = Date.parse(date1);
    const date2Ms = Date.parse(date2);
    
    const millisecondsPerDay = 1000 * 60 * 60 * 24;
    
    return Math.abs(date1Ms - date2Ms) / millisecondsPerDay;
};
