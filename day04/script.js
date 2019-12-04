console.log("Hello world!");

let output = document.querySelector(".password");

// It is a six-digit number.
// The value is within the range given in your puzzle input.
// Two adjacent digits are the same (like 22 in 122345).
// Going from left to right, the digits never decrease; they only ever increase or stay the same (like 111123 or 135679).
// Other than the range rule, the following are true:

// 111111 meets these criteria (double 11, never decreases).
// 223450 does not meet these criteria (decreasing pair of digits 50).
// 123789 does not meet these criteria (no double).

let puzzleInputLow = 146810;
let puzzleInputHigh = 612564;

const getPasswords = (low, high, length) => {
  let start = low;
  let end = high;
  let passwords = [];

  while (start < end) {
    passwords.push(start);
    start++;
  }
  let nPasswords = passwords.filter(
    pass =>
      (pass.toString()[0] >= 0 && pass.toString()[1] === pass.toString()[0]) ||
      pass.toString()[2] === pass.toString()[1] ||
      pass.toString()[3] === pass.toString()[2] ||
      pass.toString()[4] === pass.toString()[3] ||
      pass.toString()[5] === pass.toString()[4]
  );

  let n2Passwords = nPasswords.filter(
    pass =>
      pass.toString()[0] >= 0 &&
      pass.toString()[1] >= pass.toString()[0] &&
      pass.toString()[2] >= pass.toString()[1] &&
      pass.toString()[3] >= pass.toString()[2] &&
      pass.toString()[4] >= pass.toString()[3] &&
      pass.toString()[5] >= pass.toString()[4]
  );

  let n3Passwords = n2Passwords.filter(pass => {
    for (let i = 0; i < pass.toString().length; i++) {
      if (
        pass.toString()[i] === pass.toString()[i + 1] &&
        pass.toString()[i] !== pass.toString()[i - 1] &&
          pass.toString()[i + 1] !== pass.toString()[i + 2]
      ) {
        return pass;
      }
    }
  });

  console.log(n3Passwords);
};

getPasswords(146810, 612564);
