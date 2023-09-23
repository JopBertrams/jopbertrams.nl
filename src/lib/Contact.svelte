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
  }

  .contact-container {
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    text-align: center;
    width: 90%;
    max-width: 800px;
  }

  .contact-container h1 {
    margin: 60px 0;
  }

  .contact-container p {
    font-size: 1.5rem;
  }

  .contact-container a {
    margin: 60px 0;
    font-size: 1.5rem;
    color: #ffffff;
    text-decoration: none;
  }

  .contact-container a:hover {
    color: #afafaf;
    text-decoration: underline;
  }
</style>
