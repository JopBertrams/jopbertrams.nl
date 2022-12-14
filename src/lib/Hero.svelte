<script>
  import heroImage from '../assets/hero.jpg';
  import { _, locale } from 'svelte-i18n';

  function scrollToIntroduction() {
    document.querySelector('.introduction').scrollIntoView({
      behavior: 'smooth',
    });
  }

  function changeLanguage(language) {
    locale.set(language);
  }
</script>

<div>
  <div id="language-selector">
    <button
      class="language"
      title="Nederlands"
      on:click={() => changeLanguage('nl')}
    >
      NL
    </button>
    <span> | </span>
    <button
      class="language"
      title="English"
      on:click={() => changeLanguage('en')}
    >
      EN
    </button>
  </div>
  <div class="hero">
    <div class="hero-left">
      <div class="hero-text">
        <h1>Jop Bertrams</h1>
        <h2 class="typing">Full Stack Web Developer.</h2>
        <p>
          20 years old software engineering student, living in the Netherlands.
          Skilled in .NET technologies and more.
        </p>
        <button class="button" on:click={scrollToIntroduction}
          ><span>{$_('hero_button')} </span></button
        >
      </div>
    </div>
    <div class="hero-image">
      <img src={heroImage} alt="hero" />
    </div>
  </div>
</div>

<style>
  #language-selector {
    position: absolute;
    padding: 2rem;
    color: #ffffff;
    font-size: 24px;
  }

  .language {
    cursor: pointer;
    border: none;
    background-color: transparent;
    color: #ffffff;
    font-size: 24px;
  }

  .hero {
    display: flex;
    flex-direction: row;
    justify-content: space-between;
    align-items: center;
    height: 100vh;
    width: 100%;
  }

  /* .hero-left {
    width: 60%;
    height: 100%;
    display: flex;
    align-items: center;

    background: linear-gradient(to right, white 4px, transparent 4px) 20% 40%,
      linear-gradient(to bottom, white 4px, transparent 4px) 20% 40%,
      linear-gradient(to left, #ffffff 4px, transparent 4px) 80% 70%,
      linear-gradient(to top, #ffffff 4px, transparent 4px) 80% 70%;

    background-repeat: no-repeat;
    background-size: 30% 30%;
  }

  .hero-left p {
    font-size: 20px;
    text-align: center;
    width: 50%;
  } */

  .hero-left {
    width: 60%;
    height: 100%;
    display: flex;
    align-items: center;
    justify-content: center;
  }

  .hero-text {
    width: 50%;
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
  }

  .hero-text {
    position: relative;
  }
  .hero-text:before,
  .hero-text:after,
  .hero-text > :first-child:before,
  .hero-text > :first-child:after {
    position: absolute;
    content: ' ';
    width: 90px;
    height: 50px;
    border-color: #ffffff;
    border-style: solid;
  }
  .hero-text:before {
    top: -5rem;
    left: -5rem;
    border-width: 2px 0 0 2px;
  }
  .hero-text:after {
    top: -5rem;
    right: -5rem;
    border-width: 2px 2px 0 0;
  }
  .hero-text > :first-child:before {
    bottom: -5rem;
    right: -5rem;
    border-width: 0 2px 2px 0;
  }
  .hero-text > :first-child:after {
    bottom: -5rem;
    left: -5rem;
    border-width: 0 0 2px 2px;
  }

  .hero-text h1 {
    font-size: 41px;
    margin: 0;
  }

  .hero-text h2 {
    font-size: 30px;
    margin: 0;
  }

  .hero-text p {
    font-size: 26px;
    text-align: center;
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

  .button {
    border-radius: 5px;
    background-color: #0f1a20;
    border: 1px solid #fff;
    color: #ffffff;
    text-align: center;
    font-size: 20px;
    padding: 20px;
    transition: all 0.3s;
    cursor: pointer;
    margin: 5px;
  }

  .button span {
    cursor: pointer;
    display: inline-block;
    position: relative;
    transition: 0.3s;
  }

  .button span:after {
    content: '\00bb';
    position: absolute;
    opacity: 0;
    top: 0;
    right: -20px;
  }

  .button:hover {
    background-color: #fff;
    color: #262b38;
  }

  .button:hover span {
    padding-right: 25px;
  }

  .button:hover span:after {
    opacity: 1;
    right: 0;
  }

  .hero-image {
    width: 40%;
    height: 100%;
    display: flex;
    justify-content: center;
    align-items: center;
  }

  .hero-image img {
    width: 100%;
    height: 100%;
    object-fit: cover;
  }

  @media screen and (max-width: 850px) {
    .hero {
      flex-direction: column-reverse;
      justify-content: center;
      align-items: center;
      align-content: space-around;
      justify-content: space-evenly;
    }

    .hero-left {
      width: 100%;
      height: 40%;
      display: flex;
      flex-direction: column;
      justify-content: center;
      align-items: center;
      background: none;
    }

    .hero-text {
      width: 80%;
    }

    .hero-text::after,
    .hero-text::before,
    .hero-text > :first-child::after,
    .hero-text > :first-child::before {
      border: none;
    }

    .hero-image {
      position: relative;
      width: 300px;
      height: 300px;
      overflow: hidden;
      border-radius: 50%;
    }

    .hero-image img {
      position: absolute;
      top: 50%;
      left: 50%;
      transform: translate(-70%, 10%) scale(2.3);
    }
  }
</style>
