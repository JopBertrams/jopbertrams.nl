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
    </div>
    <div class="text">
      {$_('introduction')}
      <div class="socials">
        <a
          href="https://www.linkedin.com/in/jop-bertrams"
          target="_blank"
          rel="noreferrer"
        >
          <img
            src="https://img.icons8.com/fluent/48/000000/linkedin.png"
            alt="linkedin"
          />
        </a>
        <a
          href="https://github.com/JopBertrams"
          target="_blank"
          rel="noreferrer"
        >
          <img
            src="https://img.icons8.com/fluent/48/000000/github.png"
            alt="github"
          />
        </a>
        <a
          href="https://instagram.com/j.bertrams"
          target="_blank"
          rel="noreferrer"
        >
          <img
            src="https://img.icons8.com/fluent/48/000000/instagram-new.png"
            alt="instagram"
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
    height: 60vh;
    background-color: #0b1216;
  }

  .container {
    display: flex;
    flex-direction: row;
    justify-content: center;
    align-items: center;
    width: 90%;
    height: 100%;
  }

  .image {
    padding: 2rem;
    text-align: center;
  }

  .image img {
    width: 100%;
  }

  .text {
    padding: 2rem;
    text-align: center;
    color: #ffffff;
    max-width: 40%;
  }

  .socials {
    margin-top: 1rem;
  }

  @media screen and (max-width: 850px) {
    .introduction {
      flex-direction: column;
      height: 100vh;
    }

    .container {
      flex-direction: column;
      width: 100%;
    }

    .text {
      max-width: 100%;
    }
  }
</style>
