<script>
  import { _ } from 'svelte-i18n';
</script>

<div class="contact">
  <div class="contact-container">
    <h1>{$_('contact.header')}</h1>
    <p>{$_('contact.text')}</p>
    <a href="mailto:contact@jopbertrams.nl">contact@jopbertrams.nl</a>
  </div>
</div>

<style>
  .contact {
    display: flex;
    justify-content: center;
    align-items: center;
    background-color: #0b1216;
    padding: 2rem;
  }

  .contact-container {
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    text-align: center;
    max-width: 800px;
  }

  h1 {
    margin-bottom: 1rem;
  }

  .contact-container a {
    margin-top: 1.5rem;
    color: #ffffff;
    text-decoration: none;
  }

  .contact-container a:hover {
    color: #afafaf;
    text-decoration: underline;
  }
</style>
