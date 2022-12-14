<script>
  import { writable } from 'svelte/store';
  import Modal, { bind } from 'svelte-simple-modal';
  import Popup from './Popup.svelte';
  const modal = writable(null);
  const showModal = (project) => {
    // @ts-ignore
    modal.set(bind(Popup, { project: project }));
  };
  import helloworld from '../assets/helloworld.svg';
  import { _ } from 'svelte-i18n';
</script>

<Modal show={$modal} />
<div class="projects">
  <h1>Projects</h1>
  <div class="grid-container">
    <div class="grid-item">
      <div class="text">
        <div class="text-container">
          <h2>SafeSpace</h2>
          <p>
            Lorem ipsum dolor sit amet consectetur adipisicing elit. Quisquam
            voluptates, quod, quia, voluptate quae voluptatem quibusdam
            voluptatibus quos quas quidem nesciunt. Quisquam, quae. Quisquam
            voluptates, quod, quia, voluptate quae voluptatem quibusdam
            voluptatibus quos quas quidem nesciunt. Quisquam, quae.
          </p>
          <button on:click={() => showModal('safespace')}>Learn more...</button>
        </div>
      </div>
    </div>
    <div class="grid-item">
      <div class="text">
        <div class="text-container">
          <h2>Chatbot</h2>
          <p>
            Lorem ipsum dolor sit amet consectetur adipisicing elit. Quisquam
            voluptates, quod, quia, voluptate quae voluptatem quibusdam
            voluptatibus quos quas quidem nesciunt. Quisquam, quae. Quisquam
            voluptates, quod, quia, voluptate quae voluptatem quibusdam
            voluptatibus quos quas quidem nesciunt. Quisquam, quae.
          </p>
          <button on:click={() => showModal('chatbot')}>Learn more...</button>
        </div>
      </div>
    </div>
    <div class="grid-item">
      <div class="text">
        <div class="text-container">
          <h2>FlightAssistant</h2>
          <p>
            Lorem ipsum dolor sit amet consectetur adipisicing elit. Quisquam
            voluptates, quod, quia, voluptate quae voluptatem quibusdam
            voluptatibus quos quas quidem nesciunt. Quisquam, quae. Quisquam
            voluptates, quod, quia, voluptate quae voluptatem quibusdam
            voluptatibus quos quas quidem nesciunt. Quisquam, quae.
          </p>
          <button on:click={() => showModal('flightassistant')}
            >Learn more...</button
          >
        </div>
      </div>
    </div>
    <div class="grid-item">
      <div class="text">
        <div class="text-container">
          <h2>LokaWin</h2>
          <p>
            Lorem ipsum dolor sit amet consectetur adipisicing elit. Quisquam
            voluptates, quod, quia, voluptate quae voluptatem quibusdam
            voluptatibus quos quas quidem nesciunt. Quisquam, quae. Quisquam
            voluptates, quod, quia, voluptate quae voluptatem quibusdam
            voluptatibus quos quas quidem nesciunt. Quisquam, quae.
          </p>
          <button on:click={() => showModal('lokawin')}>Learn more...</button>
        </div>
      </div>
    </div>
    <div class="grid-item">
      <div class="text">
        <div class="text-container">
          <h2>Smart Asset Tracking</h2>
          <p>
            Lorem ipsum dolor sit amet consectetur adipisicing elit. Quisquam
            voluptates, quod, quia, voluptate quae voluptatem quibusdam
            voluptatibus quos quas quidem nesciunt. Quisquam, quae. Quisquam
            voluptates, quod, quia, voluptate quae voluptatem quibusdam
            voluptatibus quos quas quidem nesciunt. Quisquam, quae.
          </p>
          <button on:click={() => showModal('smartassettracking')}
            >Learn more...</button
          >
        </div>
      </div>
    </div>
    <div class="grid-item">
      <div class="text">
        <div class="text-container">
          <h2>Car Rental</h2>
          <p>
            Lorem ipsum dolor sit amet consectetur adipisicing elit. Quisquam
            voluptates, quod, quia, voluptate quae voluptatem quibusdam
            voluptatibus quos quas quidem nesciunt. Quisquam, quae. Quisquam
            voluptates, quod, quia, voluptate quae voluptatem quibusdam
            voluptatibus quos quas quidem nesciunt. Quisquam, quae.
          </p>
          <button on:click={() => showModal('carrental')}>Learn more...</button>
        </div>
      </div>
    </div>
    <div class="grid-item">
      <div class="text">
        <div class="text-container">
          <h2>Kwetter</h2>
          <p>
            Lorem ipsum dolor sit amet consectetur adipisicing elit. Quisquam
            voluptates, quod, quia, voluptate quae voluptatem quibusdam
            voluptatibus quos quas quidem nesciunt. Quisquam, quae. Quisquam
            voluptates, quod, quia, voluptate quae voluptatem quibusdam
            voluptatibus quos quas quidem nesciunt. Quisquam, quae.
          </p>
          <button on:click={() => showModal('kwetter')}>Learn more...</button>
        </div>
      </div>
    </div>
  </div>
</div>

<style>
  .projects {
    display: flex;
    justify-content: center;
    align-items: center;
    flex-direction: column;
    width: 100%;
  }

  h1 {
    margin: 60px 0;
  }

  .grid-container {
    display: grid;
    grid-template-columns: repeat(4, 1fr);
    grid-gap: 20px;
    width: 80%;
    margin-bottom: 4rem;
  }

  .grid-item {
    grid-column: span 2;
    display: flex;
    justify-content: center;
    align-items: center;
    flex-direction: column;
    background-color: #2e2e2e;
    border-radius: 10px;
    padding: 20px;
  }

  .grid-item:nth-last-child(1):nth-child(odd) {
    grid-column: 2 / span 2;
  }

  .grid-item button {
    background-color: #0b1216;
    color: white;
    border: none;
    border-radius: 5px;
    padding: 10px;
    margin-top: 20px;
    cursor: pointer;
  }
</style>
