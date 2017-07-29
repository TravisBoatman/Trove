var today = new Date();
var day = today.getDay();

var hour = today.getHours();
var minute = today.getMinutes();
var second = today.getSeconds();

var days = [
  "Sunday",
  "Monday",
  "Tuesday",
  "Wednesday",
  "Thursday",
  "Friday",
  "Saturday"
];

function formatHour(hour){
	if (hour >= 12) {
  	var hour = hour - 12;
    if (hour === 0) {
      hour + 1;
    }
    return hour + " PM";
  }
  else {
  	return hour + " AM";
  }
}

console.log("Today is: " + days[day]);
console.log("Current time is: " + formatHour(hour) + ":" + minute + ":" + second);