<script>
  import { _ } from 'svelte-i18n';

  document.addEventListener('DOMContentLoaded', function () {
    var inputs = document.querySelectorAll('.input');
    inputs.forEach(function (input, index) {
      input.addEventListener('click', function () {
        var active = document.querySelector('.active');
        active.classList.remove('active');
        input.classList.add('active');
        var activePara = document
          .querySelector('.description-flex-container')
          .querySelector('.active');
        activePara.classList.remove('active');
        var newPara = document
          .querySelector('.description-flex-container')
          .querySelector('p:nth-child(' + (index + 1) + ')');
        newPara.classList.add('active');
      });
    });
  });
</script>

<div class="timeline">
  <h1>{$_('timeline.header')}</h1>
  <div class="flex-parent">
    <div class="input-flex-container">
      <div class="input">
        <span data-year="2019" data-info="Fontys" />
      </div>
      <div class="input">
        <span data-year="2021" data-info="Cyber Security" />
      </div>
      <div class="input">
        <span data-year="2022" data-info="Curacao" />
      </div>
      <div class="input">
        <span data-year="2022" data-info="Enterprise Software" />
      </div>
      <div class="input">
        <span data-year="2023" data-info="South Africa" />
      </div>
      <div class="input active">
        <span data-year="2023" data-info="Gilde-BT" />
      </div>
      <div class="input">
        <span data-year="Future" data-info="???" />
      </div>
    </div>
    <div class="description-flex-container">
      <p>{$_('timeline.fontys')}</p>
      <p>{$_('timeline.cybersecurity')}</p>
      <p>{$_('timeline.curacao')}</p>
      <p>{$_('timeline.enterprisesoftware')}</p>
      <p>{$_('timeline.southafrica')}</p>
      <p class="active">{$_('timeline.gilde-bt')}</p>
      <p>{$_('timeline.future')}</p>
    </div>
  </div>
</div>

<style>
  .timeline {
    min-height: 50vh;
    position: relative;
    z-index: 0;
  }

  h1 {
    text-align: center;
    height: 38px;
    margin: 60px 0;
  }

  .flex-parent {
    display: flex;
    flex-direction: column;
    justify-content: center;
    align-items: center;
  }

  .input-flex-container {
    display: flex;
    justify-content: space-around;
    align-items: center;
    width: 80vw;
    height: 100px;
    max-width: 1000px;
    position: relative;
    z-index: 0;
  }

  .input {
    width: 25px;
    height: 25px;
    background-color: #94ba32;
    position: relative;
    border-radius: 50%;
  }
  .input:hover {
    cursor: pointer;
  }
  .input::before,
  .input::after {
    content: '';
    display: block;
    position: absolute;
    z-index: -1;
    top: 50%;
    transform: translateY(-50%);
    background-color: #94ba32;
    width: 4vw;
    height: 5px;
    max-width: 70px;
  }
  .input.active {
    background-color: #94ba32;
  }
  .input.active::before {
    background-color: #94ba32;
  }
  .input.active::after {
    background-color: #b2b2b2;
  }
  .input.active ~ .input,
  .input.active ~ .input::before,
  .input.active ~ .input::after {
    background-color: #b2b2b2;
  }
  .input span {
    position: absolute;
    top: 50%;
    left: 50%;
    transform: translate(-50%, -50%);
    visibility: hidden;
  }
  .input span::before,
  .input span::after {
    visibility: visible;
    position: absolute;
    left: 50%;
  }
  .input span::after {
    content: attr(data-year);
    top: 25px;
    transform: translateX(-50%);
    font-size: 16px;
  }
  .input span::before {
    content: attr(data-info);
    top: -65px;
    width: 100px;
    transform: rotateZ(-25deg);
    font-size: 12px;
    text-indent: -10px;
  }

  .description-flex-container {
    width: 80vw;
    text-align: center;
    font-size: larger;
    margin-top: 100px;
    max-width: 1000px;
  }
  .description-flex-container p {
    margin-top: 0;
    display: none;
  }
  .description-flex-container p.active {
    display: block;
  }

  @media (min-width: 850px) {
    .input::before {
      left: -59px;
    }
    .input::after {
      right: -59px;
    }
  }
  @media (max-width: 1515px) {
    .input::before {
      left: -67px;
      width: 70px;
    }
    .input::after {
      right: -67px;
      width: 70px;
    }
  }
  @media (max-width: 1200px) {
    .input::before {
      left: -55px;
      width: 60px;
    }
    .input::after {
      right: -55px;
      width: 60px;
    }
  }
  @media (max-width: 1020px) {
    .input::before {
      left: -50px;
      width: 50px;
    }
    .input::after {
      right: -50px;
      width: 50px;
    }
  }
  @media (max-width: 850px) {
    .input {
      width: 17px;
      height: 17px;
    }
    .input::before,
    .input::after {
      height: 3px;
    }
    .input::before {
      left: -40px;
    }
    .input::after {
      right: -40px;
    }
  }
  @media (max-width: 600px) {
    .flex-parent {
      justify-content: initial;
    }
    .input-flex-container {
      flex-wrap: wrap;
      justify-content: center;
      width: 100%;
      height: auto;
      margin-top: 15vh;
    }
    .input {
      width: 60px;
      height: 60px;
      margin: 0 10px 50px;
      background-color: #aeb6bf;
    }
    .input::before,
    .input::after {
      content: none;
    }
    .input span {
      width: 100%;
      height: 100%;
      display: block;
    }
    .input span::before {
      top: calc(100% + 5px);
      transform: translateX(-50%);
      text-indent: 0;
      text-align: center;
    }
    .input span::after {
      top: 50%;
      transform: translate(-50%, -50%);
      color: #ecf0f1;
    }
    .description-flex-container {
      margin-top: 30px;
      text-align: center;
    }
  }
  @media (max-width: 400px) {
    body {
      min-height: 950px;
    }
  }
</style>
