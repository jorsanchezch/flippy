import { User } from './user';

export interface Sound {
    id: number;
    name: string;
    description: string;
    audioUrl: string;
    bpm: string;
    length: number;
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