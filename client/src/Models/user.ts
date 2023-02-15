export default class User {
    constructor(
        public firstName: string,
        public lastName: string,
        public tz: string,
        public dateBorn: Date,
        public maleOrFemale: string,
        public hmo: string

    ) { }
}