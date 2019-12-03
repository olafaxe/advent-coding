const dayOne = document.querySelector(".day1");

const dayOneFunction = () => {
  // let array = [
  //   68958,
  //   82218,
  //   54333,
  //   59177,
  //   51874,
  //   100259,
  //   95468,
  //   124006,
  //   75078,
  //   113631,
  //   90315,
  //   147580,
  //   68233,
  //   81025,
  //   133084,
  //   90959,
  //   81196,
  //   92443,
  //   124832,
  //   65871,
  //   57704,
  //   140203,
  //   113053,
  //   76337,
  //   72195,
  //   115917,
  //   87843,
  //   131768,
  //   105816,
  //   131153,
  //   59714,
  //   94107,
  //   50933,
  //   139545,
  //   94969,
  //   149463,
  //   60042,
  //   66028,
  //   111190,
  //   63257,
  //   50020,
  //   88783,
  //   81428,
  //   73977,
  //   149240,
  //   137152,
  //   74738,
  //   55067,
  //   128829,
  //   56465,
  //   81962,
  //   67242,
  //   94121,
  //   92303,
  //   68477,
  //   88595,
  //   64324,
  //   82527,
  //   134717,
  //   140344,
  //   132026,
  //   137558,
  //   95643,
  //   79010,
  //   146346,
  //   86246,
  //   52341,
  //   147564,
  //   89159,
  //   66456,
  //   83190,
  //   128675,
  //   130658,
  //   122857,
  //   134538,
  //   122151,
  //   133900,
  //   117462,
  //   117791,
  //   139254,
  //   86366,
  //   66165,
  //   92897,
  //   121218,
  //   135962,
  //   143061,
  //   129220,
  //   114623,
  //   98257,
  //   76722,
  //   121014,
  //   77713,
  //   137858,
  //   133282,
  //   103595,
  //   118981,
  //   149137,
  //   101141,
  //   70765,
  //   141113
  // ];

  let array = [
    66690,
    86239,
    75191,
    140364,
    95979,
    106923,
    95229,
    123571,
    84764,
    89444,
    98107,
    89062,
    109369,
    146067,
    124760,
    76900,
    139198,
    111441,
    74046,
    84920,
    54397,
    143807,
    121654,
    93863,
    73909,
    104121,
    58485,
    119084,
    126227,
    142078,
    79820,
    132617,
    108430,
    98032,
    107434,
    127307,
    105619,
    57741,
    53468,
    63301,
    137970,
    136780,
    80897,
    133205,
    79159,
    89124,
    94477,
    56714,
    143704,
    122097,
    117335,
    108246,
    75507,
    101459,
    101162,
    146197,
    121884,
    66217,
    57074,
    142903,
    140951,
    64883,
    124556,
    67382,
    142407,
    121778,
    57933,
    94599,
    87426,
    143758,
    64043,
    65678,
    90137,
    61090,
    77315,
    102383,
    146607,
    139290,
    85394,
    149787,
    125611,
    106405,
    91561,
    135739,
    54845,
    68782,
    111175,
    61011,
    125658,
    70751,
    85607,
    75458,
    75419,
    124311,
    66022,
    122784,
    129018,
    54901,
    73788,
    108240
  ];

  let sumFuel = 0;

  const fuelAdder = (arr, calc) => {
    fuelArray = arr.map(fuel => {
      calc(fuel);
    });
    dayOne.innerHTML = `Day 1b answer: ${sumFuel}`;
  };

  const calcFuel = num => {
    num = Number(Math.floor(num / 3) - 2);
    console.log(num);
    if (num < 0) {
      return;
    } else {
      sumFuel = sumFuel + num;
      console.log(sumFuel);
      if (num > 0) {
        calcFuel(num);
      }
    }
  };
  fuelAdder(array, calcFuel);
};

dayOneFunction();