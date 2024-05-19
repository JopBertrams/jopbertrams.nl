<script>
  import globe from '../assets/globe.svg';
  import { _ } from 'svelte-i18n';
</script>

<div class="introduction">
  <div
    class="container"
    data-aos="fade-up"
    data-aos-offset="400"
    data-aos-duration="1000"
  >
    <div class="image">
      <img src={globe} alt="hello" />
      <span class="tooltiptext">{$_('introduction.tooltip')}</span>
    </div>
    <div class="text">
      {$_('introduction.text')}
      <div class="socials">
        <a
          href="https://www.linkedin.com/in/jop-bertrams"
          target="_blank"
          rel="noreferrer"
        >
          <img
            src="https://img.icons8.com/fluent/48/000000/linkedin.png"
            alt="LinkedIn"
          />
        </a>
        <a
          href="https://github.com/JopBertrams"
          target="_blank"
          rel="noreferrer"
        >
          <img
            src="https://img.icons8.com/fluent/48/000000/github.png"
            alt="GitHub"
          />
        </a>
        <a
          href="https://instagram.com/j.bertrams"
          target="_blank"
          rel="noreferrer"
        >
          <img
            src="https://img.icons8.com/fluent/48/000000/instagram-new.png"
            alt="Instagram"
          />
        </a>
      </div>
    </div>
  </div>
</div>

<style>
  .introduction {
    display: flex;
    justify-content: center;
    width: 100%;
    background-color: #0b1216;
  }

  .container {
    display: flex;
    flex-direction: row;
    justify-content: center;
    align-items: center;
  }

  .image {
    width: 30%;
    height: 75%;
    position: relative;
    text-align: center;
  }

  .image img {
    height: 100%;
  }

  .image img:hover + .tooltiptext {
    visibility: visible;
    opacity: 1;
  }

  .text {
    padding: 2rem;
    color: #ffffff;
    max-width: 40%;
  }

  .socials {
    margin-top: 1rem;
  }

  .tooltiptext {
    visibility: hidden;
    width: 300px;
    background-color: black;
    color: #fff;
    text-align: center;
    border-radius: 6px;
    padding: 5px 0;

    /* Position the tooltip */
    position: absolute;
    z-index: 1;
    top: 100%;
    left: 50%;
    margin-left: -150px;

    opacity: 0;
    transition: opacity 0.5s;
  }

  @media screen and (max-width: 1270px) {
    .image {
      width: 50%;
      height: 60%;
      position: relative;
      text-align: center;
    }
  }

  @media screen and (max-width: 850px) {
    .introduction {
      flex-direction: column;
    }

    .container {
      flex-direction: column;
      width: 100%;
    }

    .image {
      width: 40%;
      position: relative;
      margin-top: 2rem;
      margin-bottom: 0;
    }

    .text {
      max-width: 100%;
    }
  }
</style>
