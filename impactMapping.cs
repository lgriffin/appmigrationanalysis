/*
 * This is a means to automate the impact mapping scores using 3 functions.
 * We want to get a value for the PRs that are open against it
 * We want to get a value for the number of issues open against it
 * We want to get a value based on the Date
 *
*/

// Number of PRs is a key measurement of activity

function impactMappingPR(input) {
  
  if(input <= 2)
  {
    return 1;
  }
  
  if(input >= 3 && input <= 9)
  {
    return 2;
  }
  
  if(input >=10)
  {
    
    return 3;
  }
  
}

// Number of issues that are still active and open

function impactMappingIssues(input) {
  
  if(input <= 10)
  {
    return 1;
  }
  
  if(input >= 11 && input <= 25)
  {
    return 2;
  }
  
  if(input >=26)
  {
    
    return 3;
  }
  
}

// The date / year when the last update occured

function impactMappingDate(input) {
  
  if(input == "Jan" || input == 'Feb' || input == 'Mar' || input == 'Apr' || input == 'May' || input == 'Jun')
  {
    return 2;
  }
  
  if(input == 'Jul' || input == 'Aug' || input == 'Sept' || input == 'Oct' || input == 'Nov' || input == 'Dec')
  {
 return 3;   
  }
  
   if(input == "2018")
  {
    return 1;
  }
  

  else {
   
    return 0; // any other date
  }
  
}

