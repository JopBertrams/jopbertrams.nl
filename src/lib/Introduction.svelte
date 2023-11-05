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
    height: 0;
    padding-bottom: 20%;
    margin: 2rem 0;
    position: relative;
  }

  .image img {
    position: absolute;
    width: 100%;
    height: 100%;
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

  @media screen and (max-width: 1270px) {
    .image {
      width: 50%;
      height: 0;
      padding-bottom: 30%;
      position: relative;
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
      width: 50%;
      height: 0;
      padding-bottom: 40%;
      position: relative;
      margin-bottom: 0;
    }

    .text {
      max-width: 100%;
    }
  }
</style>
