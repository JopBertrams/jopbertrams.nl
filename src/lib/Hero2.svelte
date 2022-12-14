<script>
  import heroImage from '../assets/hero2.jpg';

  function scrollToIntroduction() {
    document.querySelector('.introduction').scrollIntoView({
      behavior: 'smooth',
    });
  }
</script>

<div class="hero">
  <div class="hero-left">
    <h1>Jop Bertrams</h1>
    <div class="line">
      <h2 class="typing">Full Stack Web Developer.</h2>
    </div>
    <p>
      20 years old software engineering student, living in the Netherlands.
      Skilled in .NET technologies and more.
    </p>
    <div class="button">
      <button on:click={scrollToIntroduction}>
        <span>Scroll down to discover more</span>
      </button>
    </div>
  </div>
  <div class="hero-right">
    <div class="language-selector">
      <button class="language" title="Nederlands">NL</button>
      <span class="language-divider"> | </span>
      <button class="language" title="English">EN</button>
    </div>
  </div>
  <img src={heroImage} alt="portret" class="hero-image" />
</div>

<style>
  .hero {
    position: relative;
    display: flex;
    height: 100vh;
  }

  .hero-left {
    width: 70%;
    display: flex;
    justify-content: center;
    align-items: center;
    flex-direction: column;
  }

  .hero-left h1 {
    width: 60%;
    font-size: 48px;
    margin-bottom: 0;
  }

  .line {
    width: 60%;
  }

  .typing {
    width: 25ch;
    animation: typing 2.5s steps(25), blink 0.5s step-end infinite alternate;
    white-space: nowrap;
    overflow: hidden;
    border-right: 3px solid;
    font-family: monospace;
    font-size: 30px;
    margin-top: 0;
  }

  @keyframes typing {
    from {
      width: 0;
    }
  }

  @keyframes blink {
    from,
    to {
      border-color: transparent;
    }
    50% {
      border-color: white;
    }
  }

  .hero-left p {
    width: 60%;
    font-size: 24px;
  }

  .button {
    width: 60%;
  }

  .hero-left button {
    height: 60px;
    border-radius: 5px;
    background-color: #0f1a20;
    border: 1px solid #fff;
    color: #ffffff;
    text-align: center;
    font-size: 20px;
    padding: 20px;
    transition: all 0.5s;
    cursor: pointer;
  }

  .hero-left button:hover {
    background-color: #fff;
    color: #262b38;
  }

  .hero-right {
    background-color: #121c51;
    width: 30%;
  }

  .language-selector {
    display: flex;
    justify-content: flex-end;
    margin: 3rem;
  }

  .language {
    cursor: pointer;
    border: none;
    background-color: transparent;
    color: #ffffff;
    font-size: 24px;
  }

  .language-divider {
    color: #ffffff;
    font-size: 24px;
    margin-left: 1rem;
    margin-right: 1rem;
  }

  .hero-image {
    position: absolute;
    top: 50%;
    left: 50%;
    transform: translate(50%, -50%);
    width: 300px;
    height: 300px;
    object-fit: cover;
  }
</style>
