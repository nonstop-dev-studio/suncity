const apiUrl = 'https://suncity-web.herokuapp.com/api/';

export const environment = {
  production: true,
  authRequest: apiUrl + 'account/login',
  register: apiUrl + 'account/register',
  postQuestionnaire: apiUrl + 'questionnaires',
  getQuestionnaire: apiUrl + 'questionnaires',
  postReport: apiUrl + 'reports',
  getReport: apiUrl + 'reports',
  getUser: apiUrl + 'account/current',
  getDialog: apiUrl + 'dialog',
  postDialog: apiUrl + 'dialog',
  getMessage: apiUrl + 'message',
  postMessage: apiUrl + 'message',
};
