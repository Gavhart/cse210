const form = document.getElementById('event-form');
const repoName = 'your-repo-name';
const ownerName = 'gavhart';
const token = 'your-personal-access-token';
const baseUrl = 'https://api.github.com';

const questions = [
  ['What happened today?', 'event'],
  ['How do you feel?', 'mood'],
  ['What was the highlight of your day?', 'event'],
  ['What is something you learned today?', 'event'],
  ['What did you enjoy doing today?', 'event'],
  ['What is something you accomplished today?', 'event'],
  ['What is something you struggled with today?', 'event'],
  ['What made you smile today?', 'event'],
  ['What is something you want to do tomorrow?', 'event'],
  ['What is something you are grateful for today?', 'event'],
  ['What is something that surprised you today?', 'event']
];

function getRandomQuestion() {
  const randomIndex = Math.floor(Math.random() * questions.length);
  return questions[randomIndex];
}

function updateQuestion() {
  const [questionText, inputName] = getRandomQuestion();
  const questionLabel = document.getElementById(`${inputName}-label`);
  questionLabel.textContent = questionText;
}

updateQuestion();

form.addEventListener('submit', async (e) => {
  e.preventDefault();

  const eventInput = document.getElementById('event');
  const moodInput = document.getElementById('mood');

  const eventText = eventInput.value;
  const moodText = moodInput.value;

  const date = new Date();
  const dateString = date.toISOString();

  const [questionText, _] = getRandomQuestion();

  const data = `Date: ${dateString}\n${questionText}: ${eventText}\nHow do you feel?: ${moodText}\n\n`;

  // create a new file in the GitHub repository
  const filename = `${dateString}.txt`;
