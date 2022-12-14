<div class="contact">
  <div class="contact-container">
    <h1>Contact</h1>
    <p>
      I am always looking for new opportunities to work with interesting people
      and companies. If you think we could be a good fit, please don't hesitate
      to send me a message or mail.
    </p>
    <a href="mailto:contact@jopbertrams.nl">contact@jopbertrams.nl</a>
    <div class="contact-form">
      <form>
        <input type="text" placeholder="Name" />
        <input type="email" placeholder="Email" />
        <textarea placeholder="Message" />
        <button>Send</button>
      </form>
    </div>
  </div>
</div>

<style>
  .contact {
    padding: 2rem;
    background-color: #0b1216;
    color: #ffffff;
  }

  .contact-container {
    max-width: 1200px;
    margin: 0 auto;
  }

  .contact-container p {
    width: 80%;
    margin: 2rem auto;
    text-align: center;
  }

  .contact-container a {
    display: block;
    text-align: center;
    margin-bottom: 2rem;
    color: #ffffff;
    text-decoration: none;
  }

  .contact-container a:hover {
    text-decoration: underline;
  }

  h1 {
    margin: 60px 0;
    text-align: center;
  }

  .contact-form {
    display: flex;
    justify-content: center;
  }

  .contact-form form {
    width: 100%;
    max-width: 500px;
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
  }

  .contact-form form input,
  .contact-form form textarea {
    width: 100%;
    padding: 1rem;
    margin-bottom: 1rem;
    border: none;
    border-radius: 5px;
    background-color: #1e2a33;
    color: #ffffff;
  }

  .contact-form form textarea {
    height: 200px;
    resize: none;
  }

  .contact-form form button {
    width: 80%;
    padding: 1rem;
    border: none;
    border-radius: 5px;
    background-color: #1e2a33;
    color: #ffffff;
    cursor: pointer;
  }

  .contact-form form button:hover {
    background-color: #29414f;
  }
</style>
