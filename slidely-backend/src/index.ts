import express from 'express';
import bodyParser from 'body-parser';
import cors from 'cors';
import fs from 'fs';

const app = express();
const PORT = 3000;

app.use(bodyParser.json());
app.use(cors());

interface Submission {
    name: string;
    email: string;
    phone: string;
    github_link: string;
    stopwatch_time: string;
}

app.get('/ping', (req, res) => {
    res.send(true);
});

app.post('/submit', (req, res) => {
    const newSubmission: Submission = req.body;
    const data = JSON.parse(fs.readFileSync('db.json', 'utf8')) as Submission[];
    data.push(newSubmission);
    fs.writeFileSync('db.json', JSON.stringify(data, null, 2));
    res.send('Submission received');
});

app.get('/read', (req, res) => {
    const index = parseInt(req.query.index as string, 10);
    const data = JSON.parse(fs.readFileSync('db.json', 'utf8')) as Submission[];
    if (index >= 0 && index < data.length) {
        res.json(data[index]);
    } else {
        res.status(404).send('Submission not found');
    }
});

app.listen(PORT, () => {
    console.log(`Server running at http://localhost:${PORT}`);
});
