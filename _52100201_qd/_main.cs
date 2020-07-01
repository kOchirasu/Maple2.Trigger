namespace Maple2.Trigger._52100201_qd {
    public static class _main {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 10000, arg2: true, arg3: true, arg4: true);
                context.EnableSpawnPointPc(spawnPointId: 0, isEnable: true);
                context.EnableSpawnPointPc(spawnPointId: 1, isEnable: false);
                context.SetInteractObject(arg1: new[] {12000319}, arg2: 0);
                context.SetInteractObject(arg1: new[] {12000320}, arg2: 0);
                context.SetMesh(
                    arg1: new[] {
                        2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016,
                        2017, 2018, 2019, 2020, 2021, 2022, 2023, 2024, 2025, 2026
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new[] {
                        3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016,
                        3017, 3018, 3019, 3020, 3021, 3022
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new[] {
                        1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016,
                        1017, 1018, 1019, 1020, 1021, 1022, 1023, 1024, 1025, 1026, 1027, 1028, 1029, 1030, 1031, 1032,
                        1033, 1034, 1035, 1036, 1037, 1038, 1039, 1040, 1041, 1042, 1043, 1044, 1045, 1046, 1047, 1048,
                        1049, 1050, 1051, 1052, 1053, 1054, 1055, 1056, 1057, 1058, 1059, 1060, 1061, 1062, 1063, 1064,
                        1065, 1066, 1067, 1068, 1069, 1070
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new[] {
                        1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108, 1109, 1110, 1111, 1112, 1113, 1114, 1115, 1116,
                        1117, 1118, 1119, 1120, 1121, 1122, 1123, 1124, 1125, 1126, 1127, 1128, 1129, 1130, 1131, 1132,
                        1133, 1134, 1135, 1136, 1137, 1138, 1139, 1140, 1141, 1142, 1143, 1144, 1145, 1146, 1147, 1148,
                        1149, 1150, 1151, 1152, 1153, 1154, 1155, 1156, 1157, 1158, 1159, 1160, 1161, 1162, 1163, 1164,
                        1165, 1166, 1167, 1168, 1169, 1170, 1171, 1172, 1173, 1174
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new[] {
                        101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119,
                        120, 121, 122, 123, 124, 125, 126
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new[] {
                        201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219,
                        220, 221, 222
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new[] {
                        4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010, 4011, 4012, 4013, 4014, 4015, 4016,
                        4017, 4018, 4019, 4020, 4021, 4022, 4023, 4024, 4025, 4026, 4027, 4028, 4029, 4030, 4031, 4032,
                        4033, 4034, 4035, 4036, 4037, 4038, 4039, 4040
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9001})) {
                    context.SetInteractObject(arg1: new[] {12000319}, arg2: 1);
                    context.State = new State루트생성_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State루트생성_1 : TriggerState {
            internal State루트생성_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000319}, arg2: 0)) {
                    context.State = new State루트생성_1_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State루트생성_1_1 : TriggerState {
            internal State루트생성_1_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetInteractObject(arg1: new[] {12000319}, arg2: 1);
                    context.SetMesh(
                        arg1: new[] {
                            101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118,
                            119, 120, 121, 122, 123, 124, 125, 126
                        }, arg2: true, arg3: 0, arg4: 20, arg5: 3f);
                    context.SetMesh(
                        arg1: new[] {
                            2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015,
                            2016, 2017, 2018, 2019, 2020, 2021, 2022, 2023, 2024, 2025, 2026
                        }, arg2: true, arg3: 0, arg4: 20, arg5: 3f);
                    context.State = new State배경생성_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State배경생성_1 : TriggerState {
            internal State배경생성_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetMesh(
                        arg1: new[] {
                            1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015,
                            1016, 1017, 1018, 1019, 1020, 1021, 1022, 1023, 1024, 1025, 1026, 1027, 1028, 1029, 1030,
                            1031, 1032, 1033, 1034, 1035, 1036, 1037, 1038, 1039, 1040, 1041, 1042, 1043, 1044, 1045,
                            1046, 1047, 1048, 1049, 1050, 1051, 1052, 1053, 1054, 1055, 1056, 1057, 1058, 1059, 1060,
                            1061, 1062, 1063, 1064, 1065, 1066, 1067, 1068, 1069, 1070
                        }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                    context.State = new State루트진행_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State루트진행_1 : TriggerState {
            internal State루트진행_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9002})) {
                    context.SetInteractObject(arg1: new[] {12000320}, arg2: 1);
                    context.State = new State루트생성_2(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {12000319}, arg2: 0)) {
                    context.SetMesh(
                        arg1: new[] {
                            1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015,
                            1016, 1017, 1018, 1019, 1020, 1021, 1022, 1023, 1024, 1025, 1026, 1027, 1028, 1029, 1030,
                            1031, 1032, 1033, 1034, 1035, 1036, 1037, 1038, 1039, 1040, 1041, 1042, 1043, 1044, 1045,
                            1046, 1047, 1048, 1049, 1050, 1051, 1052, 1053, 1054, 1055, 1056, 1057, 1058, 1059, 1060,
                            1061, 1062, 1063, 1064, 1065, 1066, 1067, 1068, 1069, 1070
                        }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetMesh(
                        arg1: new[] {
                            2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015,
                            2016, 2017, 2018, 2019, 2020, 2021, 2022, 2023, 2024, 2025, 2026
                        }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetMesh(
                        arg1: new[] {
                            101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118,
                            119, 120, 121, 122, 123, 124, 125, 126
                        }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.State = new State루트생성_1_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State루트생성_2 : TriggerState {
            internal State루트생성_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000320}, arg2: 0)) {
                    context.State = new State루트생성_2_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State루트생성_2_1 : TriggerState {
            internal State루트생성_2_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetInteractObject(arg1: new[] {12000320}, arg2: 1);
                    context.SetMesh(
                        arg1: new[] {
                            201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218,
                            219, 220, 221, 222
                        }, arg2: true, arg3: 0, arg4: 20, arg5: 3f);
                    context.SetMesh(
                        arg1: new[] {
                            3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015,
                            3016, 3017, 3018, 3019, 3020, 3021, 3022
                        }, arg2: true, arg3: 0, arg4: 20, arg5: 3f);
                    context.State = new State배경생성_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State배경생성_2 : TriggerState {
            internal State배경생성_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetMesh(
                        arg1: new[] {
                            1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108, 1109, 1110, 1111, 1112, 1113, 1114, 1115,
                            1116, 1117, 1118, 1119, 1120, 1121, 1122, 1123, 1124, 1125, 1126, 1127, 1128, 1129, 1130,
                            1131, 1132, 1133, 1134, 1135, 1136, 1137, 1138, 1139, 1140, 1141, 1142, 1143, 1144, 1145,
                            1146, 1147, 1148, 1149, 1150, 1151, 1152, 1153, 1154, 1155, 1156, 1157, 1158, 1159, 1160,
                            1161, 1162, 1163, 1164, 1165, 1166, 1167, 1168, 1169, 1170, 1171, 1172, 1173, 1174
                        }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                    context.State = new State루트진행_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State루트진행_2 : TriggerState {
            internal State루트진행_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9003})) {
                    context.EnableSpawnPointPc(spawnPointId: 0, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 1, isEnable: true);
                    context.State = new State기믹2(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {12000320}, arg2: 0)) {
                    context.SetMesh(
                        arg1: new[] {
                            3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015,
                            3016, 3017, 3018, 3019, 3020, 3021, 3022
                        }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetMesh(
                        arg1: new[] {
                            201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218,
                            219, 220, 221, 222
                        }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetMesh(
                        arg1: new[] {
                            1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108, 1109, 1110, 1111, 1112, 1113, 1114, 1115,
                            1116, 1117, 1118, 1119, 1120, 1121, 1122, 1123, 1124, 1125, 1126, 1127, 1128, 1129, 1130,
                            1131, 1132, 1133, 1134, 1135, 1136, 1137, 1138, 1139, 1140, 1141, 1142, 1143, 1144, 1145,
                            1146, 1147, 1148, 1149, 1150, 1151, 1152, 1153, 1154, 1155, 1156, 1157, 1158, 1159, 1160,
                            1161, 1162, 1163, 1164, 1165, 1166, 1167, 1168, 1169, 1170, 1171, 1172, 1173, 1174
                        }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.State = new State루트생성_2_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State기믹2 : TriggerState {
            internal State기믹2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1001, 1002, 1003, 1004, 1005}, arg2: false);
                context.SetMesh(arg1: new[] {4001, 4002}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {4004, 4005}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {4008}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {4009}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {4018}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {4020, 4021}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {4025, 4026}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {4027}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {4033, 4034}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetUserValue(triggerId: 910002, key: "Cube", value: 1);
                    context.SetUserValue(triggerId: 910004, key: "Cube", value: 1);
                    context.SetUserValue(triggerId: 910007, key: "Cube", value: 1);
                    context.SetUserValue(triggerId: 910008, key: "Cube", value: 1);
                    context.SetUserValue(triggerId: 910009, key: "Cube", value: 1);
                    context.SetUserValue(triggerId: 910011, key: "Cube", value: 1);
                    context.SetUserValue(triggerId: 910013, key: "Cube", value: 1);
                    context.SetUserValue(triggerId: 910016, key: "Cube", value: 1);
                    context.SetUserValue(triggerId: 910017, key: "Cube", value: 1);
                    context.SetUserValue(triggerId: 910019, key: "Cube", value: 1);
                    context.SetUserValue(triggerId: 910020, key: "Cube", value: 1);
                    context.State = new State기믹끝(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State기믹끝 : TriggerState {
            internal State기믹끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9005})) {
                    context.DestroyMonster(arg1: new[] {1001, 1002, 1003, 1004, 1005}, arg2: false);
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}