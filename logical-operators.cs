

// | - OR, evaluates both operands
bool x1 = (5 > 6) | (4 < 6); // TRUE because 5 > 6 - false, 4 < 6 - true 
bool x2 = (5 > 6) | (4 > 6); // FALSE because 5 > 6 - false, 4 > 6 - false 

// || - lazy OR
bool x1 = (5 > 6) || (4 < 6); // TRUE because 5 > 6 - false, 4 < 6 - true 
bool x2 = (5 > 6) || (4 > 6); // FALSE because 5 > 6 - false, 4 > 6 - false 

// & - AND, evaluates both operands
bool x1 = (5 > 6) & (4 < 6); // FALSE because 5 > 6 - false, 4 < 6 - true 
bool x2 = (5 < 6) & (4 < 6); // TRUE because 5 < 6 - true, 4 < 6 - true 

// && lazy AND
bool x1 = (5 > 6) && (4 < 6); // FALSE because 5 > 6 - false, 4 < 6 - true 
bool x2 = (5 < 6) && (4 < 6); // TRUE because 5 < 6 - true, 4 < 6 - true 

// ! - NOT
bool a = true;
bool b = !a;    // false

// ^ - XOR (true if exactly one operand is true)
bool x5 = (5 > 6) ^ (4 < 6);      // TRUE because 5 > 6 - false, 4 < 6 - true 
bool x6 = (50 > 6) ^ (4 / 2 < 3); // FALSE because 50 > 6 - true, 4/2 < 3 - true 
if (isDay ^ isNight) { ... }


