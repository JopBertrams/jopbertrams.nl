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
        <span data-year="2019" data-info={$_('timeline.fontys.info')} />
      </div>
      <div class="input">
        <span data-year="2021" data-info={$_('timeline.cybersecurity.info')} />
      </div>
      <div class="input">
        <span data-year="2022" data-info={$_('timeline.curacao.info')} />
      </div>
      <div class="input">
        <span
          data-year="2022"
          data-info={$_('timeline.enterprisesoftware.info')}
        />
      </div>
      <div class="input">
        <span data-year="2023" data-info={$_('timeline.southafrica.info')} />
      </div>
      <div class="input active">
        <span data-year="2023" data-info={$_('timeline.gilde-bt.info')} />
      </div>
      <div class="input">
        <span
          data-year={$_('timeline.future.year')}
          data-info={$_('timeline.future.info')}
        />
      </div>
    </div>
    <div class="description-flex-container">
      <p>{$_('timeline.fontys.text')}</p>
      <p>{$_('timeline.cybersecurity.text')}</p>
      <p>{$_('timeline.curacao.text')}</p>
      <p>{$_('timeline.enterprisesoftware.text')}</p>
      <p>{$_('timeline.southafrica.text')}</p>
      <p class="active">{$_('timeline.gilde-bt.text')}</p>
      <p>{$_('timeline.future.text')}</p>
    </div>
  </div>
</div>

<style>
  .timeline {
    /* min-height: 50vh; */
    position: relative;
    z-index: 0;
    padding: 2rem;
  }

  h1 {
    text-align: center;
    margin-bottom: 100px;
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
    /* height: 100px; */
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
    font-size: 1.2em;
  }
  .input span::before {
    content: attr(data-info);
    top: -75px;
    width: 150px;
    transform: rotateZ(-25deg);
    text-indent: -10px;
  }

  .description-flex-container {
    width: 80vw;
    text-align: center;
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
    h1 {
      margin-bottom: 0;
    }

    .flex-parent {
      justify-content: initial;
    }
    .input-flex-container {
      flex-wrap: wrap;
      justify-content: center;
      width: 100%;
      margin-top: 2rem;
    }
    .input {
      width: 60px;
      height: 60px;
      margin: 30px 10px;
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
      max-width: 60px;
    }
    .input span::after {
      top: 50%;
      transform: translate(-50%, -50%);
      color: #ecf0f1;
    }
    .description-flex-container {
      margin-top: 60px;
      text-align: center;
    }
    .input-flex-container .input:last-child > span::after {
      font-size: 12px;
    }
  }
</style>
