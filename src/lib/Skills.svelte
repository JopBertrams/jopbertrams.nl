<div class="skills">
  <div class="skills-container">
    <h1>Skills</h1>
    <div class="skills-grid">
      <div class="skills-grid-item">
        <div class="skills-grid-item-container">
          <h3>HTML</h3>
          <div class="skills-grid-item-container-bar">
            <div class="skills-grid-item-container-bar-fill html" />
            <span class="tooltiptext">8/10</span>
          </div>
        </div>
      </div>
      <div class="skills-grid-item">
        <div class="skills-grid-item-container">
          <h3>CSS</h3>
          <div class="skills-grid-item-container-bar">
            <div class="skills-grid-item-container-bar-fill css" />
            <span class="tooltiptext">7/10</span>
          </div>
        </div>
      </div>
      <div class="skills-grid-item">
        <div class="skills-grid-item-container">
          <h3>JavaScript</h3>
          <div class="skills-grid-item-container-bar">
            <div class="skills-grid-item-container-bar-fill js" />
            <span class="tooltiptext">8/10</span>
          </div>
        </div>
      </div>
      <div class="skills-grid-item">
        <div class="skills-grid-item-container">
          <h3>Node.js</h3>
          <div class="skills-grid-item-container-bar">
            <div class="skills-grid-item-container-bar-fill node" />
            <span class="tooltiptext">8/10</span>
          </div>
        </div>
      </div>
      <div class="skills-grid-item">
        <div class="skills-grid-item-container">
          <h3>Svelte</h3>
          <div class="skills-grid-item-container-bar">
            <div class="skills-grid-item-container-bar-fill svelte" />
            <span class="tooltiptext">4/10</span>
          </div>
        </div>
      </div>
      <div class="skills-grid-item">
        <div class="skills-grid-item-container">
          <h3>Vue.js</h3>
          <div class="skills-grid-item-container-bar">
            <div class="skills-grid-item-container-bar-fill vue" />
            <span class="tooltiptext">9/10</span>
          </div>
        </div>
      </div>
      <div class="skills-grid-item">
        <div class="skills-grid-item-container">
          <h3>.NET (C#)</h3>
          <div class="skills-grid-item-container-bar">
            <div class="skills-grid-item-container-bar-fill dotnet" />
            <span class="tooltiptext">10/10</span>
          </div>
        </div>
      </div>
      <div class="skills-grid-item">
        <div class="skills-grid-item-container">
          <h3>Xamarin</h3>
          <div class="skills-grid-item-container-bar">
            <div class="skills-grid-item-container-bar-fill xamarin" />
            <span class="tooltiptext">4/10</span>
          </div>
        </div>
      </div>
      <div class="skills-grid-item">
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
    width: 40%;
    background-color: #ff3c00;
  }

  .dotnet {
    width: 100%;
    background-color: #5c2d91;
  }

  .xamarin {
    width: 40%;
    background-color: #3498db;
  }

  .docker {
    width: 70%;
    background-color: #2497ed;
  }

  @media screen and (max-width: 768px) {
    .skills-grid {
      grid-template-columns: repeat(auto-fit, minmax(200px, 1fr));
    }
  }

  @media screen and (max-width: 480px) {
    .skills-grid {
      grid-template-columns: repeat(auto-fit, minmax(150px, 1fr));
    }
  }

  @media screen and (max-width: 360px) {
    .skills-grid {
      grid-template-columns: repeat(auto-fit, minmax(100px, 1fr));
    }
  }
</style>
