<!-- svelte-ignore a11y-click-events-have-key-events -->
<script>
  // @ts-nocheck
  import { format, json } from 'svelte-i18n';

  export let project = '';

  const images = $json('projects.' + project + '.images');
  const descriptionParagraphs = $json('projects.' + project + '.description');
  const usedTechnologies = $json('projects.' + project + '.technologies');

  const handleDotClick = (index) => {
    const modalImages = document.querySelectorAll('.modal .image');
    const dots = document.querySelectorAll('.modal .dot');
    modalImages.forEach((image, i) => {
      if (i == index) {
        image.style.display = 'block';
      } else {
        image.style.display = 'none';
      }
    });

    dots.forEach((dot, i) => {
      if (i == index) {
        dot.style.backgroundColor = '#000000';
      } else {
        dot.style.backgroundColor = '#8A8A8A';
      }
    });
  };

  const previousImage = () => {
    const modalImages = document.querySelectorAll('.modal .image');
    const dots = document.querySelectorAll('.modal .dot');
    let index = 0;
    modalImages.forEach((image, i) => {
      if (image.style.display == 'block') {
        index = i;
      }
    });

    if (index == 0) {
      index = modalImages.length - 1;
    } else {
      index--;
    }

    modalImages.forEach((image, i) => {
      if (i == index) {
        image.style.display = 'block';
      } else {
        image.style.display = 'none';
      }
    });

    dots.forEach((dot, i) => {
      if (i == index) {
        dot.style.backgroundColor = '#000000';
      } else {
        dot.style.backgroundColor = '#8A8A8A';
      }
    });
  };

  const nextImage = () => {
    const modalImages = document.querySelectorAll('.modal .image');
    const dots = document.querySelectorAll('.modal .dot');
    let index = 0;
    modalImages.forEach((image, i) => {
      if (image.style.display == 'block') {
        index = i;
      }
    });

    if (index == modalImages.length - 1) {
      index = 0;
    } else {
      index++;
    }

    modalImages.forEach((image, i) => {
      if (i == index) {
        image.style.display = 'block';
      } else {
        image.style.display = 'none';
      }
    });

    dots.forEach((dot, i) => {
      if (i == index) {
        dot.style.backgroundColor = '#000000';
      } else {
        dot.style.backgroundColor = '#8A8A8A';
      }
    });
  };
</script>

<div class="modal">
  <div class="header">
    <div class="logo">
      <img src={$format('projects.' + project + '.logo')} alt="logo" />
    </div>
    <div class="title">
      <h1>{$format('projects.' + project + '.title')}</h1>
    </div>
  </div>
  {#each images as image, i}
    {#if i == 0}
      <img src={image} alt="projectimage" class="image" />
    {:else}
      <img
        src={image}
        alt="projectimage"
        width="100%"
        style="display: none;"
        class="image"
      />
    {/if}
  {/each}
  <div class="dots">
    <button class="previous" on:click={() => previousImage()}>
      <svg
        width="24"
        height="24"
        viewBox="0 0 24 24"
        fill="none"
        xmlns="http://www.w3.org/2000/svg"
      >
        <path
          d="M15.41 16.09L10.83 11.5L15.41 6.91L14 5.5L8 11.5L14 17.5L15.41 16.09Z"
          fill="#8A8A8A"
        />
      </svg>
    </button>
    {#each images as image, i}
      {#if i == 0}
        <button
          class="dot"
          style="background-color: #000000;"
          on:click={() => handleDotClick(i)}
        />
      {:else}
        <button
          class="dot"
          style="background-color: #8A8A8A"
          on:click={() => handleDotClick(i)}
        />
      {/if}
    {/each}
    <button class="next" on:click={() => nextImage()}>
      <svg
        width="24"
        height="24"
        viewBox="0 0 24 24"
        fill="none"
        xmlns="http://www.w3.org/2000/svg"
      >
        <path
          d="M8.59 7.91L13.17 12.5L8.59 17.09L10 18.5L16 12.5L10 6.5L8.59 7.91Z"
          fill="#8A8A8A"
        />
      </svg>
    </button>
  </div>
  <div class="text">
    <h2>{$format('projects.description_header')}</h2>
    {#each descriptionParagraphs as paragraph, i}
      <p>{paragraph}</p>
      {#if i < descriptionParagraphs.length - 1}
        <br />
      {/if}
    {/each}
    <h2>{$format('projects.technologies_header')}</h2>
    <ul>
      {#each usedTechnologies as technology}
        <li>{technology}</li>
      {/each}
    </ul>
    <h2>{$format('projects.stakeholder_header')}</h2>
    <a
      href={$format('projects.' + project + '.stakeholder_link')}
      target="_blank"
      rel="noreferrer"
      >{$format('projects.' + project + '.stakeholder')}
    </a>
  </div>
</div>

<style>
  .header {
    display: flex;
    align-items: center;
    margin-bottom: 20px;
  }

  .logo {
    width: 100px;
    height: 100px;
    margin-right: 20px;
  }

  .logo img {
    width: 100%;
    height: 100%;
    object-fit: contain;
  }

  .image {
    max-height: 80vh;
    max-width: 100%;
    width: auto;
    margin: auto;
    display: block;
  }

  button {
    background: none;
    color: inherit;
    border: none;
    padding: 0;
    font: inherit;
    cursor: pointer;
    outline: inherit;
  }

  button:focus {
    outline: 2px solid #000;
  }

  .dots {
    display: flex;
    justify-content: center;
    align-items: center;
    margin: 20px 0;
  }

  .dots .previous {
    width: 24px;
    height: 24px;
    margin-right: 10px;
    cursor: pointer;
  }

  .dot {
    width: 15px;
    height: 15px;
    border-radius: 50%;
    margin: 0 5px;
    cursor: pointer;
  }

  .dots .next {
    width: 24px;
    height: 24px;
    margin-left: 10px;
    cursor: pointer;
  }

  .dots .previous:hover,
  .dots .next:hover {
    opacity: 0.5;
  }

  .text {
    max-width: 80%;
    margin: 30px auto;
  }

  a {
    color: #000000;
    text-decoration: none;
  }

  a:hover {
    text-decoration: underline;
  }

  a:focus {
    text-decoration: underline;
  }

  ul {
    list-style-position: inside;
  }
</style>
