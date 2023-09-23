<script>
  window.addEventListener('load', () => {
    const loader = document.getElementById('loader-container');
    loader.style.opacity = '0';
    loader.style.visibility = 'hidden';
  });

  import AOS from 'aos';
  import Hero from './lib/Hero.svelte';
  import Introduction from './lib/Introduction.svelte';
  import Timeline from './lib/Timeline.svelte';
  import Skills from './lib/Skills.svelte';
  import Projects from './lib/Projects.svelte';
  import Contact from './lib/Contact.svelte';
  import Footer from './lib/Footer.svelte';
  import { onMount } from 'svelte';

  onMount(() => {
    AOS.init();
  });
</script>

<svelte:head>
  <link rel="stylesheet" href="https://unpkg.com/aos@next/dist/aos.css" />
</svelte:head>

<main>
  <div id="loader-container">
    <span class="loader" />
  </div>
  <Hero />
  <Introduction />
  <Timeline />
  <Skills />
  <Projects />
  <Contact />
  <Footer />
</main>

<style>
  #loader-container {
    position: fixed;
    top: 0;
    left: 0;
    width: 100%;
    height: 100%;
    background-color: #0b1216;
    z-index: 9999;
    display: flex;
    justify-content: center;
    align-items: center;
    transition: opacity 0.25s, visibility 1s;
  }

  .loader {
    transform: rotateZ(45deg);
    width: 100px;
    height: 100px;
    color: #fff;
  }
  .loader:before,
  .loader:after {
    content: '';
    display: block;
    position: absolute;
    top: 0;
    left: 0;
    width: inherit;
    height: inherit;
    border-radius: 50%;
    transform: rotateX(70deg);
    animation: 1s spin linear infinite;
  }
  .loader:after {
    color: #ff0000;
    transform: rotateY(70deg);
    animation-delay: 0.4s;
  }

  @keyframes rotate {
    0% {
      transform: translate(-50%, -50%) rotateZ(0deg);
    }
    100% {
      transform: translate(-50%, -50%) rotateZ(360deg);
    }
  }

  @keyframes rotateccw {
    0% {
      transform: translate(-50%, -50%) rotate(0deg);
    }
    100% {
      transform: translate(-50%, -50%) rotate(-360deg);
    }
  }

  @keyframes spin {
    0%,
    100% {
      box-shadow: 0.2em 0px 0 0px currentcolor;
    }
    12% {
      box-shadow: 0.2em 0.2em 0 0 currentcolor;
    }
    25% {
      box-shadow: 0 0.2em 0 0px currentcolor;
    }
    37% {
      box-shadow: -0.2em 0.2em 0 0 currentcolor;
    }
    50% {
      box-shadow: -0.2em 0 0 0 currentcolor;
    }
    62% {
      box-shadow: -0.2em -0.2em 0 0 currentcolor;
    }
    75% {
      box-shadow: 0px -0.2em 0 0 currentcolor;
    }
    87% {
      box-shadow: 0.2em -0.2em 0 0 currentcolor;
    }
  }
</style>
