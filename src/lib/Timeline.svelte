<script>
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
  <h1>Timeline</h1>
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
      <div class="input active">
        <span data-year="2022" data-info="Enterprise Software" />
      </div>
      <div class="input">
        <span data-year="2023" data-info="South Africa" />
      </div>
      <div class="input">
        <span data-year="Future" data-info="???" />
      </div>
    </div>
    <div class="description-flex-container">
      <p>
        In 2019, I began my journey in the field of ICT at Fontys University of
        Applied Sciences in Eindhoven. The main course of my study is Software
        Engineering.
      </p>
      <p>
        I did one semester with the specialisation Cyber Security where I have
        gained some good knowledge of Ethical Hacking and Risk Consulting. I
        analysed the security of diverse IT environments with common pen-testing
        tools, such as Nmap, Metasploit, Wireshark and Burp Suite. I also
        analysed security threats and resulting business risks according to risk
        analysis methods and advised a client on security improvements of an IT
        environment on a physical, technical and organizational level.
      </p>
      <p>
        From February 2022 to July 2022 I did my internship Software Engineering
        on Curacao. This semester was truly a once-in-a-lifetime experience
        where I met lovely people and was able to immerse myself in a vibrant
        culture. It was a unique opportunity to learn and grow as a person, and
        I am grateful for the memories and experiences that I will always
        treasure.
      </p>
      <p class="active">
        I am currently doing a semester of advanced enterprise software
        engineering, where I am learning everything about scalable microservice
        architectures, cloud services, and Kubernetes. It has been a challenging
        and rewarding experience, as I am gaining in-depth knowledge and
        practical skills that will be valuable in my future career as a software
        developer.
      </p>
      <p>
        In January 2023 I am embarking on an exciting journey to learn about AI
        and Machine Learning at a university in Pretoria. During my time in
        South Africa, I will learn a variety of languages, development
        environments, and frameworks that will allow myself to create
        sophisticated AI solutions. This is a great opportunity to gain valuable
        knowledge and skills in a rapidly growing field. In addition to learning
        about AI and Machine Learning, I will also have the chance to experience
        the unique culture of South Africa. From its stunning natural beauty to
        its vibrant cities.
      </p>
      <p>
        As a software developer, I am excited for the limitless possibilities
        that my future holds and am eager to continue learning and growing in
        this dynamic field.
      </p>
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
    background-color: #ccff66;
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
    background-color: #ccff66;
    width: 8vw;
    height: 5px;
    max-width: 80px;
  }
  .input.active {
    background-color: #ccff66;
  }
  .input.active::before {
    background-color: #ccff66;
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

  @media screen and (max-width: 850px) {
    .timeline {
      height: 100vh;
    }
  }

  @media (min-width: 770px) {
    .input::before {
      left: -71px;
    }
    .input::after {
      right: -71px;
    }
  }

  @media (max-width: 770px) {
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
      background-color: #b2b2b2;
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
      color: #000000;
    }
    .description-flex-container {
      margin-top: 30px;
      text-align: center;
    }
  }
</style>
