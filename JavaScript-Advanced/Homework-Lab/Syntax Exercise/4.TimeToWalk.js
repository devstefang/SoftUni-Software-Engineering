function walk(steps,footStep,speed){
    let distanceMeters = steps * footStep;
  let speedMetersSec = speed / 3.6;
  let time = distanceMeters / speedMetersSec;
  let rest = Math.floor(distanceMeters / 500);

  let timeMin = Math.floor(time / 60);
  let timeSec = Math.round(time - (timeMin * 60));
  let timeHr = Math.floor(time / 3600)
  console.log((timeHr < 10 ? "0" : "") + timeHr + ":" + (timeMin + rest < 10 ? "0" : "") + (timeMin + rest) + ":" + (timeSec < 10 ? "0" : "") + timeSec);
}
walk(4000, 0.60, 1);