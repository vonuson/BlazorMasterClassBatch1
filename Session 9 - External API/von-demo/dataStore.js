const low = require('lowdb');
const FileSync = require('lowdb/adapters/FileSync');
const { v4: uuidv4 } = require('uuid');

class DataStore {
  constructor(collectionName, defaultValue) {
    const adapter = new FileSync('db.json');

    this.db = low(adapter);

    const defaultObj = {};

    defaultObj[collectionName] = defaultValue;

    this.db.defaults(defaultObj).write();
    this.collectionName = collectionName;
  }

  generateId() {
    return uuidv4();
  }

  getAll() {
    return this.db
      .get(this.collectionName)
      .value();
  }

  getByUsername(userName) {
    return this.db
      .get(this.collectionName)
      .filter({ userName })
      .value();
  }

  getUserByEmail(emailAddress) {
    return this.db
      .get(this.collectionName)
      .filter({ emailAddress })
      .value();
  }

  insert(data) {
    this.db
      .get(this.collectionName)
      .push(data)
      .write();
  }

  update(id, data) {
    this.db
      .get(this.collectionName)
      .find({ id })
      .assign(data)
      .write();
  }

  remove(id) {
    this.db
      .get(this.collectionName)
      .remove({ id })
      .write();
  }
}

module.exports = DataStore;
