function stopwatch() {
   let time = document.getElementById('time');
   let startButton = document.getElementById('startBtn');
   let stopButton = document.getElementById('stopBtn');
   let interval;
   startButton.addEventListener('click', function(e){
    	time.textContent = '00:00';
        stopButton.removeAttribute('disabled');
        e.currentTarget.setAttribute('disabled',true);
        
        interval = setInterval(function(){

            let currentTime = time.textContent;
            let timeArray = currentTime.split(':');
            let minutes = Number(timeArray[0]);
            let seconds = Number(timeArray[1]);
            seconds++;
            if (seconds > 59) {
                minutes++;
                seconds = 0;
            }
            time.textContent = `${minutes.toString().padStart(2,'0')}:${seconds.toString().padStart(2,'0')}`
        },1000)
   })
   stopButton.addEventListener('click', function(e){
    clearInterval(interval)
    e.currentTarget.setAttribute('disabled',true);
    startButton.removeAttribute('disabled');
   })
}