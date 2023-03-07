import { User } from './user';

export interface Sound {
    id: number;
    name: string;
    description: string;
    audioFile: string;
    bpm: number;
    keyRoot: string;
    keyMod: string;
    keyForm: string;
    users: User[];
    instruments: Instrument[];
    genres: Genre[];
}

export interface Instrument {
    id: number;
    name: string;
}

export interface Genre {
    id: number;
    name: string;
}
