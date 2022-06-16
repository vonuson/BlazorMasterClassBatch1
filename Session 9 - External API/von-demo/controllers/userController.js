const DataStore = require('../dataStore');

const userDataStore = new DataStore('users', []);
const emailPattern = /[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+(?:[A-Z]{2}|com|org|net|gov|mil|biz|info|mobi|name|aero|jobs|museum)\b/;
const isEmailValid = email => emailPattern.test(email);

exports.getAllUser = (req, res) => {
  const users = userDataStore.getAll();

  res.status(200).send(users);
};

exports.insertUserValidator = (req, res, next) => {
  const requiredProps = ['userName', 'emailAddress', 'firstName', 'lastName'];
  const bodyProps = Object.keys(req.body);

  const propsAreValid = requiredProps.every(propName => bodyProps.includes(propName));
  const emailAddress = (req.body.emailAddress || '').toLowerCase();
  const userName = (req.body.userName || '').toLowerCase();

  if (!propsAreValid) {
    res.status(400).send('User is not valid');
  } else if (!isEmailValid(emailAddress)) {
    res.status(400).send('Email is not valid');
  } else {
    const isUserExists = userDataStore.getByUsername(userName).length;
    const isEmailExists = userDataStore.getUserByEmail(emailAddress).length;

    if (isUserExists) {
      res.status(409).send('Username is already taken');
    } else if (isEmailExists) {
      res.status(409).send('Email address is already taken');
    } else {
      next();
    }
  }
};

exports.insertUser = (req, res) => {
  const id = userDataStore.generateId();
  const user = {
    id,
    userName: req.body.userName.toLowerCase(),
    emailAddress: req.body.emailAddress.toLowerCase(),
    firstName: req.body.firstName,
    lastName: req.body.lastName
  }

  userDataStore.insert({
    id,
    ...user
  });

  res.sendStatus(201);
};

exports.updateUserValidator = (req, res, next) => {
  const bodyUserName = req.body.userName || '';
  const bodyEmailAddress = req.body.emailAddress || '';
  const userList = userDataStore.getByUsername(req.params.userName);
  const user = userList && userList[0];

  if (!userList.length) {
    res.status(404).send('User does not exists');
  } else if (!isEmailValid(bodyEmailAddress)) {
    res.status(400).send('Email is not valid');
  } else {
    const userNameToUpdate = userDataStore.getByUsername(bodyUserName.toLowerCase());
    const emailAddressToUpdate = userDataStore.getUserByEmail(bodyEmailAddress.toLowerCase());

    if (userNameToUpdate.length && userNameToUpdate[0].userName !== user.userName) {
      res.status(409).send('Username is already taken');
    } else if (emailAddressToUpdate.length && emailAddressToUpdate[0].emailAddress !== user.emailAddress) {
      res.status(409).send('Email address is already taken');
    } else {
      res.locals.id = user.id;

      next();
    }
  }
};

exports.updateUser = (req, res) => {
  const id = res.locals.id;
  let user = req.body;
  if (!user.id) {
    user = { id, ...user }
  }

  userDataStore.update(id, user);

  res.sendStatus(200);
};

exports.getUserValidator = (req, res, next) => {
  const userName = req.params.userName || '';
  const userList = userDataStore.getByUsername(userName.toLowerCase());

  if (!userList.length) {
    res.status(404).send('User does not exists');
  } else {
    res.locals.user = userList[0];

    next();
  }
}

exports.getUser = (req, res) => {
  res.status(200).send(res.locals.user);
}

exports.getUserByEmailValidator = (req, res, next) => {
  const emailAddress = req.params.emailAddress || '';
  const userList = userDataStore.getUserByEmail(emailAddress.toLowerCase());

  if (!userList.length) {
    res.status(404).send('Email does not exists');
  } else {
    res.locals.user = userList[0];

    next();
  }
}

exports.getUserByEmail = (req, res) => {
  res.status(200).send(res.locals.user);
}

exports.deleteUserValidator = (req, res, next) => {
  const userName = req.params.userName;
  const userList = userDataStore.getByUsername(userName);

  if (!userList.length) {
    res.status(404).send('User does not exists');
  } else {
    res.locals.id = userList[0] && userList[0].id;

    next();
  }
}

exports.deleteUser = (req, res) => {
  userDataStore.remove(res.locals.id);

  res.sendStatus(200);
};
