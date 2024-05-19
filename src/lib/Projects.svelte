<script>
  import { writable } from 'svelte/store';
  import Modal, { bind } from 'svelte-simple-modal';
  import Popup from './ProjectPopup.svelte';
  const modal = writable(null);
  const showModal = (project) => {
    // @ts-ignore
    modal.set(bind(Popup, { project: project }));
  };
  import { _ } from 'svelte-i18n';
</script>

<Modal
  show={$modal}
  on:closing={() => {}}
  styleBg={{ backgroundColor: 'rgba(0, 0, 0, 1)' }}
  styleWindow={{ width: '90%', maxWidth: '900px' }}
  styleCloseButton={{ margin: '10px' }}
/>
<div class="projects">
  <h1>{$_('projects.header')}</h1>
  <div class="grid-container">
    <div class="grid-item" data-aos="zoom-in-right">
      <div class="text">
        <div class="text-container">
          <h2>SafeSpace</h2>
          <p>{$_('projects.safespace.short_description')}</p>
        </div>
        <button on:click={() => showModal('safespace')}
          >{$_('projects.learnmore_button')}</button
        >
      </div>
    </div>
    <div class="grid-item" data-aos="zoom-in-left">
      <div class="text">
        <div class="text-container">
          <h2>Chatbot</h2>
          <p>{$_('projects.chatbot.short_description')}</p>
        </div>
        <button on:click={() => showModal('chatbot')}
          >{$_('projects.learnmore_button')}</button
        >
      </div>
    </div>
    <div class="grid-item" data-aos="zoom-in-right">
      <div class="text">
        <div class="text-container">
          <h2>FlightAssistant</h2>
          <p>{$_('projects.flightassistant.short_description')}</p>
        </div>
        <button on:click={() => showModal('flightassistant')}
          >{$_('projects.learnmore_button')}</button
        >
      </div>
    </div>
    <div class="grid-item" data-aos="zoom-in-left">
      <div class="text">
        <div class="text-container">
          <h2>LokaWin</h2>
          <p>{$_('projects.lokawin.short_description')}</p>
        </div>
        <button on:click={() => showModal('lokawin')}
          >{$_('projects.learnmore_button')}</button
        >
      </div>
    </div>
    <div class="grid-item" data-aos="zoom-in-right">
      <div class="text">
        <div class="text-container">
          <h2>Smart Asset Tracking</h2>
          <p>{$_('projects.smartassettracking.short_description')}</p>
        </div>
        <button on:click={() => showModal('smartassettracking')}
          >{$_('projects.learnmore_button')}</button
        >
      </div>
    </div>
    <div class="grid-item" data-aos="zoom-in-left">
      <div class="text">
        <div class="text-container">
          <h2>Car Rental</h2>
          <p>{$_('projects.carrental.short_description')}</p>
        </div>
        <button on:click={() => showModal('carrental')}
          >{$_('projects.learnmore_button')}</button
        >
      </div>
    </div>
    <!-- <div class="grid-item" data-aos="zoom-in-right">
      <div class="text">
        <div class="text-container">
          <h2>Kwetter</h2>
          <p>{$_('projects.kwetter.short_description')}</p>
          <button on:click={() => showModal('kwetter')}>{$_('projects.learnmore_button')}</button>
        </div>
      </div>
    </div>
    <div class="grid-item" data-aos="zoom-in-left">
      <div class="text">
        <div class="text-container">
          <h2>De Oefenpraktijk</h2>
          <p>{$_('projects.oefenpraktijk.short_description')}</p>
          <button on:click={() => showModal('oefenpraktijk')}
            >{$_('projects.learnmore_button')}</button
          >
        </div>
      </div>
    </div> -->
  </div>
</div>

<style>
  .projects {
    display: flex;
    justify-content: center;
    align-items: center;
    flex-direction: column;
    width: 100%;
    padding: 2rem;
  }

  h1 {
    margin-bottom: 2rem;
  }

  .grid-container {
    display: grid;
    grid-template-columns: repeat(4, 1fr);
    grid-gap: 20px;
    max-width: 1200px;
    margin-bottom: 4rem;
  }

  .grid-item {
    position: relative;
    grid-column: span 2;
    display: flex;
    justify-content: center;
    align-items: center;
    flex-direction: column;
    background-color: #2e2e2e;
    border-radius: 10px;
    padding: 20px;
  }

  .text {
    display: flex;
    justify-content: center;
    align-items: flex-start;
    flex-direction: column;
    height: 100%;
  }

  .text-container {
    display: flex;
    flex-direction: column;
    height: 100%;
    align-items: flex-start;
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

  @media screen and (max-width: 768px) {
    .grid-container {
      grid-template-columns: repeat(2, 1fr);
    }

    .grid-item:nth-last-child(1):nth-child(odd) {
      grid-column: 1 / span 2;
    }
  }
</style>
