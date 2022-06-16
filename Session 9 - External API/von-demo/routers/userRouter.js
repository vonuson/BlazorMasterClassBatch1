const express = require('express');
const userController = require('../controllers/userController');

const router = express.Router();

router.get('/', userController.getAllUser);
router.post('/', userController.insertUserValidator, userController.insertUser);
router.get('/user/:userName', userController.getUserValidator, userController.getUser);
router.put('/user/:userName', userController.updateUserValidator, userController.updateUser);
router.delete('/user/:userName', userController.deleteUserValidator, userController.deleteUser);
router.get('/user/email/:emailAddress', userController.getUserByEmailValidator, userController.getUserByEmail);

module.exports = router;
