<script>
  import { _ } from 'svelte-i18n';
</script>

<div class="skills">
  <div class="skills-container">
    <h1>{$_('skills')}</h1>
    <div class="skills-grid">
      <div class="skills-grid-item" data-aos="fade-down-right">
        <div class="skills-grid-item-container">
          <h3>HTML</h3>
          <div class="skills-grid-item-container-bar">
            <div class="skills-grid-item-container-bar-fill html" />
            <span class="tooltiptext">8/10</span>
          </div>
        </div>
      </div>
      <div class="skills-grid-item" data-aos="fade-down">
        <div class="skills-grid-item-container">
          <h3>CSS</h3>
          <div class="skills-grid-item-container-bar">
            <div class="skills-grid-item-container-bar-fill css" />
            <span class="tooltiptext">7/10</span>
          </div>
        </div>
      </div>
      <div class="skills-grid-item" data-aos="fade-down-left">
        <div class="skills-grid-item-container">
          <h3>JavaScript</h3>
          <div class="skills-grid-item-container-bar">
            <div class="skills-grid-item-container-bar-fill js" />
            <span class="tooltiptext">8/10</span>
          </div>
        </div>
      </div>
      <div class="skills-grid-item" data-aos="fade-right">
        <div class="skills-grid-item-container">
          <h3>Node.js</h3>
          <div class="skills-grid-item-container-bar">
            <div class="skills-grid-item-container-bar-fill node" />
            <span class="tooltiptext">8/10</span>
          </div>
        </div>
      </div>
      <div class="skills-grid-item" data-aos="zoom-in">
        <div class="skills-grid-item-container">
          <h3>Svelte</h3>
          <div class="skills-grid-item-container-bar">
            <div class="skills-grid-item-container-bar-fill svelte" />
            <span class="tooltiptext">6/10</span>
          </div>
        </div>
      </div>
      <div class="skills-grid-item" data-aos="fade-left">
        <div class="skills-grid-item-container">
          <h3>Vue.js</h3>
          <div class="skills-grid-item-container-bar">
            <div class="skills-grid-item-container-bar-fill vue" />
            <span class="tooltiptext">9/10</span>
          </div>
        </div>
      </div>
      <div class="skills-grid-item" data-aos="fade-up-right">
        <div class="skills-grid-item-container">
          <h3>.NET (C#)</h3>
          <div class="skills-grid-item-container-bar">
            <div class="skills-grid-item-container-bar-fill dotnet" />
            <span class="tooltiptext">10/10</span>
          </div>
        </div>
      </div>
      <div class="skills-grid-item" data-aos="fade-up">
        <div class="skills-grid-item-container">
          <h3>Oracle Cloud</h3>
          <div class="skills-grid-item-container-bar">
            <div class="skills-grid-item-container-bar-fill oracle" />
            <span class="tooltiptext">4/10</span>
          </div>
        </div>
      </div>
      <div class="skills-grid-item" data-aos="fade-up-left">
        <div class="skills-grid-item-container">
          <h3>Docker & Kubernetes</h3>
          <div class="skills-grid-item-container-bar">
            <div class="skills-grid-item-container-bar-fill docker" />
            <span class="tooltiptext">7/10</span>
          </div>
        </div>
      </div>
    </div>
  </div>
</div>

<style>
  .skills {
    padding: 2rem;
    background-color: #0b1216;
    color: #ffffff;
    overflow: hidden;
  }

  .skills-container {
    max-width: 1200px;
    margin: 0 auto;
  }

  h1 {
    margin: 60px 0;
    text-align: center;
  }

  .skills-grid {
    display: grid;
    grid-template-columns: repeat(auto-fit, minmax(300px, 1fr));
    grid-gap: 1rem;
  }

  .skills-grid-item {
    display: flex;
    justify-content: center;
    align-items: center;
    padding: 1rem;
    background-color: #2e2e2e;
    border-radius: 5px;
  }

  .skills-grid-item-container {
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
    width: 100%;
  }

  .skills-grid-item-container h3 {
    margin-bottom: 1rem;
  }

  .skills-grid-item-container-bar {
    position: relative;
    width: 100%;
    height: 20px;
    background-color: #ffffff;
    border-radius: 5px;
  }

  .skills-grid-item-container-bar-fill {
    height: 100%;
    border-radius: 5px;
  }

  .tooltiptext {
    visibility: hidden;
    width: 120px;
    background-color: black;
    color: #fff;
    text-align: center;
    border-radius: 6px;
    padding: 5px 0;

    /* Position the tooltip */
    position: absolute;
    z-index: 1;
    top: 100%;
    left: 50%;
    margin-left: -60px;

    opacity: 0;
    transition: opacity 0.5s;
  }

  .skills-grid-item-container-bar:hover .tooltiptext {
    visibility: visible;
    opacity: 1;
  }

  .html {
    width: 80%;
    background-color: #e34c26;
  }

  .css {
    width: 70%;
    background-color: #1774bb;
  }

  .js {
    width: 80%;
    background-color: #f0db4f;
  }

  .node {
    width: 80%;
    background-color: #90c53f;
  }

  .vue {
    width: 90%;
    background-color: #42b883;
  }

  .svelte {
    width: 60%;
    background-color: #ff3c00;
  }

  .dotnet {
    width: 100%;
    background-color: #5c2d91;
  }

  .oracle {
    width: 40%;
    background-color: #ee1d24;
  }

  .docker {
    width: 70%;
    background-color: #2497ed;
  }

  @media screen and (max-width: 1007px) {
    .skills-grid {
      grid-template-columns: repeat(auto-fit, minmax(250px, 1fr));
    }
  }

  @media screen and (max-width: 857px) {
    .skills-grid {
      grid-template-columns: repeat(auto-fit, minmax(200px, 1fr));
    }
  }

  @media screen and (max-width: 725px) and (min-width: 504px) {
    .skills-grid {
      grid-template-columns: repeat(4, 1fr);
    }

    .skills-grid-item {
      grid-column: span 2;
    }

    .skills-grid-item:nth-last-child(1):nth-child(odd) {
      grid-column: 2 / span 2;
    }
  }

  @media screen and (max-width: 504px) {
    .skills-grid {
      grid-template-columns: repeat(1, 1fr);
    }
  }
</style>
