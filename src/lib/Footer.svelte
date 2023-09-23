<div class="footer">
  <div class="text">
    <img src="/logo.png" alt="logo" />
    <p>© 2022, Built by Jop with Svelte</p>
  </div>
  <div class="links">
    <a href="https://github.com/JopBertrams" target="_blank" rel="noreferrer"
      >GitHub</a
    >
    <a
      href="https://www.linkedin.com/in/jop-bertrams"
      target="_blank"
      rel="noreferrer">LinkedIn</a
    >
    <a href="https://instagram.com/j.bertrams" target="_blank" rel="noreferrer"
      >Instagram</a
    >
  </div>
</div>

<style>
  .footer {
    display: flex;
    flex-direction: row;
    justify-content: space-between;
    align-items: center;
    color: #fff;
    padding: 1rem;
    text-align: center;
  }

  .text {
    display: flex;
    justify-content: center;
    align-items: center;
    padding: 2rem;
    text-align: center;
    color: #ffffff;
  }

  .text img {
    width: 50px;
    height: 50px;
    margin-right: 1rem;
  }

  .links {
    padding: 2rem;
  }

  .links a {
    margin: 0 1rem;
    color: #ffffff;
    text-decoration: none;
  }

  .links a:hover {
    color: #747474;
  }
</style>
