const videoPlayer = document.querySelector('.video-player');
const video = videoPlayer.querySelector('.video');
const playButton = videoPlayer.querySelector('.button-finish');
const form = document.querySelector('form');
const descritivo = videoPlayer.querySelector('.descritivo');

form.addEventListener('submit', (e) => {
    e.preventDefault(); 

    if (video.paused) {
        video.play();
        playButton.textContent = 'TOASTY!';

        setTimeout(() => {
            window.location.href = '../Lutadores/vencedor';
        }, 19000); 
        
        setTimeout(() => {
            descritivo.style.display = 'none';
            playButton.style.display = 'none';
        }, 50);

        setTimeout(() => {
            form.submit();
        }, 19000); 
    }
});
