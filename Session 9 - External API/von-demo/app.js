const express = require('express');
const userRouter = require('./routers/userRouter');
const cors = require('cors');

const app = express();

const port = process.env.port || 3000;

app.use(cors({
  origin: '*'
}));

app.use(express.json());
app.use('/users', userRouter);

app.get('/', (req, res, next) => {
  res.redirect('/users');
});

app.listen(port, () => {
  console.log(`Server is now listening to port: ${port}`);
});
