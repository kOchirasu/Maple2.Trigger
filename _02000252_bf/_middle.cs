namespace Maple2.Trigger._02000252_bf {
    public static class _middle {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8201}, arg2: false);
                context.SetEffect(arg1: new[] {8202}, arg2: false);
                context.SetEffect(arg1: new[] {8203}, arg2: false);
                context.SetEffect(arg1: new[] {8204}, arg2: false);
                context.SetEffect(arg1: new[] {8205}, arg2: false);
                context.SetEffect(arg1: new[] {8206}, arg2: false);
                context.SetEffect(arg1: new[] {8207}, arg2: false);
                context.SetEffect(arg1: new[] {8208}, arg2: false);
                context.SetEffect(arg1: new[] {8209}, arg2: false);
                context.SetEffect(arg1: new[] {8210}, arg2: false);
                context.SetEffect(arg1: new[] {8211}, arg2: false);
                context.SetEffect(arg1: new[] {8212}, arg2: false);
                context.SetEffect(arg1: new[] {8213}, arg2: false);
                context.SetEffect(arg1: new[] {8214}, arg2: false);
                context.SetEffect(arg1: new[] {8215}, arg2: false);
                context.SetEffect(arg1: new[] {8216}, arg2: false);
                context.SetEffect(arg1: new[] {8217}, arg2: false);
                context.SetEffect(arg1: new[] {8218}, arg2: false);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 902) == 1) {
                    context.State = new State바닥삭제(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State바닥삭제 : TriggerState {
            internal State바닥삭제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 5);
                context.SetMesh(
                    arg1: new[] {
                        101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119,
                        120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138,
                        139, 140, 141, 142
                    }, arg2: false, arg3: 0, arg4: 100);
                context.CreateMonster(arg1: new[] {1075}, arg2: false);
                context.CreateMonster(arg1: new[] {1076}, arg2: false);
                context.CreateMonster(arg1: new[] {1077}, arg2: false);
                context.CreateMonster(arg1: new[] {1078}, arg2: false);
                context.CreateMonster(arg1: new[] {1079}, arg2: false);
                context.CreateMonster(arg1: new[] {1080}, arg2: false);
                context.CreateMonster(arg1: new[] {1081}, arg2: false);
                context.CreateMonster(arg1: new[] {1082}, arg2: false);
                context.CreateMonster(arg1: new[] {1083}, arg2: false);
                context.CreateMonster(arg1: new[] {1084}, arg2: false);
                context.CreateMonster(arg1: new[] {1085}, arg2: false);
                context.CreateMonster(arg1: new[] {1086}, arg2: false);
                context.CreateMonster(arg1: new[] {1087}, arg2: false);
                context.CreateMonster(arg1: new[] {1088}, arg2: false);
                context.CreateMonster(arg1: new[] {1089}, arg2: false);
                context.CreateMonster(arg1: new[] {1090}, arg2: false);
                context.CreateMonster(arg1: new[] {1091}, arg2: false);
                context.CreateMonster(arg1: new[] {1092}, arg2: false);
                context.CreateMonster(arg1: new[] {1093}, arg2: false);
                context.CreateMonster(arg1: new[] {1094}, arg2: false);
                context.SetEffect(arg1: new[] {8201}, arg2: true);
                context.SetEffect(arg1: new[] {8202}, arg2: true);
                context.SetEffect(arg1: new[] {8203}, arg2: true);
                context.SetEffect(arg1: new[] {8204}, arg2: true);
                context.SetEffect(arg1: new[] {8205}, arg2: true);
                context.SetEffect(arg1: new[] {8206}, arg2: true);
                context.SetEffect(arg1: new[] {8207}, arg2: true);
                context.SetEffect(arg1: new[] {8208}, arg2: true);
                context.SetEffect(arg1: new[] {8209}, arg2: true);
                context.SetEffect(arg1: new[] {8210}, arg2: true);
                context.SetEffect(arg1: new[] {8211}, arg2: true);
                context.SetEffect(arg1: new[] {8212}, arg2: true);
                context.SetEffect(arg1: new[] {8213}, arg2: true);
                context.SetEffect(arg1: new[] {8214}, arg2: true);
                context.SetEffect(arg1: new[] {8215}, arg2: true);
                context.SetEffect(arg1: new[] {8216}, arg2: true);
                context.SetEffect(arg1: new[] {8217}, arg2: true);
                context.SetEffect(arg1: new[] {8218}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State스킬01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬01 : TriggerState {
            internal State스킬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetEffect(arg1: new[] {8201}, arg2: false);
                context.SetEffect(arg1: new[] {8202}, arg2: false);
                context.SetEffect(arg1: new[] {8203}, arg2: false);
                context.SetEffect(arg1: new[] {8204}, arg2: false);
                context.SetEffect(arg1: new[] {8205}, arg2: false);
                context.SetEffect(arg1: new[] {8206}, arg2: false);
                context.SetEffect(arg1: new[] {8207}, arg2: false);
                context.SetEffect(arg1: new[] {8208}, arg2: false);
                context.SetEffect(arg1: new[] {8209}, arg2: false);
                context.SetEffect(arg1: new[] {8210}, arg2: false);
                context.SetEffect(arg1: new[] {8211}, arg2: false);
                context.SetEffect(arg1: new[] {8212}, arg2: false);
                context.SetEffect(arg1: new[] {8213}, arg2: false);
                context.SetEffect(arg1: new[] {8214}, arg2: false);
                context.SetEffect(arg1: new[] {8215}, arg2: false);
                context.SetEffect(arg1: new[] {8216}, arg2: false);
                context.SetEffect(arg1: new[] {8217}, arg2: false);
                context.SetEffect(arg1: new[] {8218}, arg2: false);
                context.SetSkill(arg1: new[] {1301}, arg2: true);
                context.SetSkill(arg1: new[] {1302}, arg2: true);
                context.SetSkill(arg1: new[] {1303}, arg2: true);
                context.SetSkill(arg1: new[] {1304}, arg2: true);
                context.SetSkill(arg1: new[] {1305}, arg2: true);
                context.SetSkill(arg1: new[] {1306}, arg2: true);
                context.SetSkill(arg1: new[] {1307}, arg2: true);
                context.SetSkill(arg1: new[] {1308}, arg2: true);
                context.SetSkill(arg1: new[] {1309}, arg2: true);
                context.SetSkill(arg1: new[] {1310}, arg2: true);
                context.SetSkill(arg1: new[] {1311}, arg2: true);
                context.SetSkill(arg1: new[] {1312}, arg2: true);
                context.SetSkill(arg1: new[] {1313}, arg2: true);
                context.SetSkill(arg1: new[] {1314}, arg2: true);
                context.SetSkill(arg1: new[] {1315}, arg2: true);
                context.SetSkill(arg1: new[] {1316}, arg2: true);
                context.SetSkill(arg1: new[] {1317}, arg2: true);
                context.SetSkill(arg1: new[] {1318}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬02대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬02대기 : TriggerState {
            internal State스킬02대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1301}, arg2: false);
                context.SetSkill(arg1: new[] {1302}, arg2: false);
                context.SetSkill(arg1: new[] {1303}, arg2: false);
                context.SetSkill(arg1: new[] {1304}, arg2: false);
                context.SetSkill(arg1: new[] {1305}, arg2: false);
                context.SetSkill(arg1: new[] {1306}, arg2: false);
                context.SetSkill(arg1: new[] {1307}, arg2: false);
                context.SetSkill(arg1: new[] {1308}, arg2: false);
                context.SetSkill(arg1: new[] {1309}, arg2: false);
                context.SetSkill(arg1: new[] {1310}, arg2: false);
                context.SetSkill(arg1: new[] {1311}, arg2: false);
                context.SetSkill(arg1: new[] {1312}, arg2: false);
                context.SetSkill(arg1: new[] {1313}, arg2: false);
                context.SetSkill(arg1: new[] {1314}, arg2: false);
                context.SetSkill(arg1: new[] {1315}, arg2: false);
                context.SetSkill(arg1: new[] {1316}, arg2: false);
                context.SetSkill(arg1: new[] {1317}, arg2: false);
                context.SetSkill(arg1: new[] {1318}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬02 : TriggerState {
            internal State스킬02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1307}, arg2: true);
                context.SetSkill(arg1: new[] {1308}, arg2: true);
                context.SetSkill(arg1: new[] {1309}, arg2: true);
                context.SetSkill(arg1: new[] {1310}, arg2: true);
                context.SetSkill(arg1: new[] {1311}, arg2: true);
                context.SetSkill(arg1: new[] {1312}, arg2: true);
                context.SetSkill(arg1: new[] {1313}, arg2: true);
                context.SetSkill(arg1: new[] {1314}, arg2: true);
                context.SetSkill(arg1: new[] {1315}, arg2: true);
                context.SetSkill(arg1: new[] {1316}, arg2: true);
                context.SetSkill(arg1: new[] {1317}, arg2: true);
                context.SetSkill(arg1: new[] {1318}, arg2: true);
                context.SetSkill(arg1: new[] {1319}, arg2: true);
                context.SetSkill(arg1: new[] {1320}, arg2: true);
                context.SetSkill(arg1: new[] {1321}, arg2: true);
                context.SetSkill(arg1: new[] {1322}, arg2: true);
                context.SetSkill(arg1: new[] {1323}, arg2: true);
                context.SetSkill(arg1: new[] {1324}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬03대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬03대기 : TriggerState {
            internal State스킬03대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1307}, arg2: false);
                context.SetSkill(arg1: new[] {1308}, arg2: false);
                context.SetSkill(arg1: new[] {1309}, arg2: false);
                context.SetSkill(arg1: new[] {1310}, arg2: false);
                context.SetSkill(arg1: new[] {1311}, arg2: false);
                context.SetSkill(arg1: new[] {1312}, arg2: false);
                context.SetSkill(arg1: new[] {1313}, arg2: false);
                context.SetSkill(arg1: new[] {1314}, arg2: false);
                context.SetSkill(arg1: new[] {1315}, arg2: false);
                context.SetSkill(arg1: new[] {1316}, arg2: false);
                context.SetSkill(arg1: new[] {1317}, arg2: false);
                context.SetSkill(arg1: new[] {1318}, arg2: false);
                context.SetSkill(arg1: new[] {1319}, arg2: false);
                context.SetSkill(arg1: new[] {1320}, arg2: false);
                context.SetSkill(arg1: new[] {1321}, arg2: false);
                context.SetSkill(arg1: new[] {1322}, arg2: false);
                context.SetSkill(arg1: new[] {1323}, arg2: false);
                context.SetSkill(arg1: new[] {1324}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬03 : TriggerState {
            internal State스킬03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1313}, arg2: true);
                context.SetSkill(arg1: new[] {1314}, arg2: true);
                context.SetSkill(arg1: new[] {1315}, arg2: true);
                context.SetSkill(arg1: new[] {1316}, arg2: true);
                context.SetSkill(arg1: new[] {1317}, arg2: true);
                context.SetSkill(arg1: new[] {1318}, arg2: true);
                context.SetSkill(arg1: new[] {1319}, arg2: true);
                context.SetSkill(arg1: new[] {1320}, arg2: true);
                context.SetSkill(arg1: new[] {1321}, arg2: true);
                context.SetSkill(arg1: new[] {1322}, arg2: true);
                context.SetSkill(arg1: new[] {1323}, arg2: true);
                context.SetSkill(arg1: new[] {1324}, arg2: true);
                context.SetSkill(arg1: new[] {1325}, arg2: true);
                context.SetSkill(arg1: new[] {1326}, arg2: true);
                context.SetSkill(arg1: new[] {1327}, arg2: true);
                context.SetSkill(arg1: new[] {1328}, arg2: true);
                context.SetSkill(arg1: new[] {1328}, arg2: true);
                context.SetSkill(arg1: new[] {1330}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬04대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬04대기 : TriggerState {
            internal State스킬04대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1313}, arg2: false);
                context.SetSkill(arg1: new[] {1314}, arg2: false);
                context.SetSkill(arg1: new[] {1315}, arg2: false);
                context.SetSkill(arg1: new[] {1316}, arg2: false);
                context.SetSkill(arg1: new[] {1317}, arg2: false);
                context.SetSkill(arg1: new[] {1318}, arg2: false);
                context.SetSkill(arg1: new[] {1319}, arg2: false);
                context.SetSkill(arg1: new[] {1320}, arg2: false);
                context.SetSkill(arg1: new[] {1321}, arg2: false);
                context.SetSkill(arg1: new[] {1322}, arg2: false);
                context.SetSkill(arg1: new[] {1323}, arg2: false);
                context.SetSkill(arg1: new[] {1324}, arg2: false);
                context.SetSkill(arg1: new[] {1325}, arg2: false);
                context.SetSkill(arg1: new[] {1326}, arg2: false);
                context.SetSkill(arg1: new[] {1327}, arg2: false);
                context.SetSkill(arg1: new[] {1328}, arg2: false);
                context.SetSkill(arg1: new[] {1328}, arg2: false);
                context.SetSkill(arg1: new[] {1330}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬04 : TriggerState {
            internal State스킬04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1319}, arg2: true);
                context.SetSkill(arg1: new[] {1320}, arg2: true);
                context.SetSkill(arg1: new[] {1321}, arg2: true);
                context.SetSkill(arg1: new[] {1322}, arg2: true);
                context.SetSkill(arg1: new[] {1323}, arg2: true);
                context.SetSkill(arg1: new[] {1324}, arg2: true);
                context.SetSkill(arg1: new[] {1325}, arg2: true);
                context.SetSkill(arg1: new[] {1326}, arg2: true);
                context.SetSkill(arg1: new[] {1327}, arg2: true);
                context.SetSkill(arg1: new[] {1328}, arg2: true);
                context.SetSkill(arg1: new[] {1328}, arg2: true);
                context.SetSkill(arg1: new[] {1330}, arg2: true);
                context.SetSkill(arg1: new[] {1331}, arg2: true);
                context.SetSkill(arg1: new[] {1332}, arg2: true);
                context.SetSkill(arg1: new[] {1333}, arg2: true);
                context.SetSkill(arg1: new[] {1334}, arg2: true);
                context.SetSkill(arg1: new[] {1335}, arg2: true);
                context.SetSkill(arg1: new[] {1336}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬05대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬05대기 : TriggerState {
            internal State스킬05대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1319}, arg2: false);
                context.SetSkill(arg1: new[] {1320}, arg2: false);
                context.SetSkill(arg1: new[] {1321}, arg2: false);
                context.SetSkill(arg1: new[] {1322}, arg2: false);
                context.SetSkill(arg1: new[] {1323}, arg2: false);
                context.SetSkill(arg1: new[] {1324}, arg2: false);
                context.SetSkill(arg1: new[] {1325}, arg2: false);
                context.SetSkill(arg1: new[] {1326}, arg2: false);
                context.SetSkill(arg1: new[] {1327}, arg2: false);
                context.SetSkill(arg1: new[] {1328}, arg2: false);
                context.SetSkill(arg1: new[] {1328}, arg2: false);
                context.SetSkill(arg1: new[] {1330}, arg2: false);
                context.SetSkill(arg1: new[] {1331}, arg2: false);
                context.SetSkill(arg1: new[] {1332}, arg2: false);
                context.SetSkill(arg1: new[] {1333}, arg2: false);
                context.SetSkill(arg1: new[] {1334}, arg2: false);
                context.SetSkill(arg1: new[] {1335}, arg2: false);
                context.SetSkill(arg1: new[] {1336}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬05 : TriggerState {
            internal State스킬05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1325}, arg2: true);
                context.SetSkill(arg1: new[] {1326}, arg2: true);
                context.SetSkill(arg1: new[] {1327}, arg2: true);
                context.SetSkill(arg1: new[] {1328}, arg2: true);
                context.SetSkill(arg1: new[] {1328}, arg2: true);
                context.SetSkill(arg1: new[] {1330}, arg2: true);
                context.SetSkill(arg1: new[] {1331}, arg2: true);
                context.SetSkill(arg1: new[] {1332}, arg2: true);
                context.SetSkill(arg1: new[] {1333}, arg2: true);
                context.SetSkill(arg1: new[] {1334}, arg2: true);
                context.SetSkill(arg1: new[] {1335}, arg2: true);
                context.SetSkill(arg1: new[] {1336}, arg2: true);
                context.SetSkill(arg1: new[] {1337}, arg2: true);
                context.SetSkill(arg1: new[] {1338}, arg2: true);
                context.SetSkill(arg1: new[] {1339}, arg2: true);
                context.SetSkill(arg1: new[] {1340}, arg2: true);
                context.SetSkill(arg1: new[] {1341}, arg2: true);
                context.SetSkill(arg1: new[] {1342}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬06대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬06대기 : TriggerState {
            internal State스킬06대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1325}, arg2: false);
                context.SetSkill(arg1: new[] {1326}, arg2: false);
                context.SetSkill(arg1: new[] {1327}, arg2: false);
                context.SetSkill(arg1: new[] {1328}, arg2: false);
                context.SetSkill(arg1: new[] {1328}, arg2: false);
                context.SetSkill(arg1: new[] {1330}, arg2: false);
                context.SetSkill(arg1: new[] {1331}, arg2: false);
                context.SetSkill(arg1: new[] {1332}, arg2: false);
                context.SetSkill(arg1: new[] {1333}, arg2: false);
                context.SetSkill(arg1: new[] {1334}, arg2: false);
                context.SetSkill(arg1: new[] {1335}, arg2: false);
                context.SetSkill(arg1: new[] {1336}, arg2: false);
                context.SetSkill(arg1: new[] {1337}, arg2: false);
                context.SetSkill(arg1: new[] {1338}, arg2: false);
                context.SetSkill(arg1: new[] {1339}, arg2: false);
                context.SetSkill(arg1: new[] {1340}, arg2: false);
                context.SetSkill(arg1: new[] {1341}, arg2: false);
                context.SetSkill(arg1: new[] {1342}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬06 : TriggerState {
            internal State스킬06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1331}, arg2: true);
                context.SetSkill(arg1: new[] {1332}, arg2: true);
                context.SetSkill(arg1: new[] {1333}, arg2: true);
                context.SetSkill(arg1: new[] {1334}, arg2: true);
                context.SetSkill(arg1: new[] {1335}, arg2: true);
                context.SetSkill(arg1: new[] {1336}, arg2: true);
                context.SetSkill(arg1: new[] {1337}, arg2: true);
                context.SetSkill(arg1: new[] {1338}, arg2: true);
                context.SetSkill(arg1: new[] {1339}, arg2: true);
                context.SetSkill(arg1: new[] {1340}, arg2: true);
                context.SetSkill(arg1: new[] {1341}, arg2: true);
                context.SetSkill(arg1: new[] {1342}, arg2: true);
                context.SetSkill(arg1: new[] {1343}, arg2: true);
                context.SetSkill(arg1: new[] {1344}, arg2: true);
                context.SetSkill(arg1: new[] {1345}, arg2: true);
                context.SetSkill(arg1: new[] {1346}, arg2: true);
                context.SetSkill(arg1: new[] {1347}, arg2: true);
                context.SetSkill(arg1: new[] {1348}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬07대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬07대기 : TriggerState {
            internal State스킬07대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1331}, arg2: false);
                context.SetSkill(arg1: new[] {1332}, arg2: false);
                context.SetSkill(arg1: new[] {1333}, arg2: false);
                context.SetSkill(arg1: new[] {1334}, arg2: false);
                context.SetSkill(arg1: new[] {1335}, arg2: false);
                context.SetSkill(arg1: new[] {1336}, arg2: false);
                context.SetSkill(arg1: new[] {1337}, arg2: false);
                context.SetSkill(arg1: new[] {1338}, arg2: false);
                context.SetSkill(arg1: new[] {1339}, arg2: false);
                context.SetSkill(arg1: new[] {1340}, arg2: false);
                context.SetSkill(arg1: new[] {1341}, arg2: false);
                context.SetSkill(arg1: new[] {1342}, arg2: false);
                context.SetSkill(arg1: new[] {1343}, arg2: false);
                context.SetSkill(arg1: new[] {1344}, arg2: false);
                context.SetSkill(arg1: new[] {1345}, arg2: false);
                context.SetSkill(arg1: new[] {1346}, arg2: false);
                context.SetSkill(arg1: new[] {1347}, arg2: false);
                context.SetSkill(arg1: new[] {1348}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬07 : TriggerState {
            internal State스킬07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1337}, arg2: true);
                context.SetSkill(arg1: new[] {1338}, arg2: true);
                context.SetSkill(arg1: new[] {1339}, arg2: true);
                context.SetSkill(arg1: new[] {1340}, arg2: true);
                context.SetSkill(arg1: new[] {1341}, arg2: true);
                context.SetSkill(arg1: new[] {1342}, arg2: true);
                context.SetSkill(arg1: new[] {1343}, arg2: true);
                context.SetSkill(arg1: new[] {1344}, arg2: true);
                context.SetSkill(arg1: new[] {1345}, arg2: true);
                context.SetSkill(arg1: new[] {1346}, arg2: true);
                context.SetSkill(arg1: new[] {1347}, arg2: true);
                context.SetSkill(arg1: new[] {1348}, arg2: true);
                context.SetSkill(arg1: new[] {1349}, arg2: true);
                context.SetSkill(arg1: new[] {1350}, arg2: true);
                context.SetSkill(arg1: new[] {1351}, arg2: true);
                context.SetSkill(arg1: new[] {1352}, arg2: true);
                context.SetSkill(arg1: new[] {1353}, arg2: true);
                context.SetSkill(arg1: new[] {1354}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬08대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬08대기 : TriggerState {
            internal State스킬08대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1337}, arg2: false);
                context.SetSkill(arg1: new[] {1338}, arg2: false);
                context.SetSkill(arg1: new[] {1339}, arg2: false);
                context.SetSkill(arg1: new[] {1340}, arg2: false);
                context.SetSkill(arg1: new[] {1341}, arg2: false);
                context.SetSkill(arg1: new[] {1342}, arg2: false);
                context.SetSkill(arg1: new[] {1343}, arg2: false);
                context.SetSkill(arg1: new[] {1344}, arg2: false);
                context.SetSkill(arg1: new[] {1345}, arg2: false);
                context.SetSkill(arg1: new[] {1346}, arg2: false);
                context.SetSkill(arg1: new[] {1347}, arg2: false);
                context.SetSkill(arg1: new[] {1348}, arg2: false);
                context.SetSkill(arg1: new[] {1349}, arg2: false);
                context.SetSkill(arg1: new[] {1350}, arg2: false);
                context.SetSkill(arg1: new[] {1351}, arg2: false);
                context.SetSkill(arg1: new[] {1352}, arg2: false);
                context.SetSkill(arg1: new[] {1353}, arg2: false);
                context.SetSkill(arg1: new[] {1354}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬08 : TriggerState {
            internal State스킬08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1343}, arg2: true);
                context.SetSkill(arg1: new[] {1344}, arg2: true);
                context.SetSkill(arg1: new[] {1345}, arg2: true);
                context.SetSkill(arg1: new[] {1346}, arg2: true);
                context.SetSkill(arg1: new[] {1347}, arg2: true);
                context.SetSkill(arg1: new[] {1348}, arg2: true);
                context.SetSkill(arg1: new[] {1349}, arg2: true);
                context.SetSkill(arg1: new[] {1350}, arg2: true);
                context.SetSkill(arg1: new[] {1351}, arg2: true);
                context.SetSkill(arg1: new[] {1352}, arg2: true);
                context.SetSkill(arg1: new[] {1353}, arg2: true);
                context.SetSkill(arg1: new[] {1354}, arg2: true);
                context.SetSkill(arg1: new[] {1355}, arg2: true);
                context.SetSkill(arg1: new[] {1356}, arg2: true);
                context.SetSkill(arg1: new[] {1357}, arg2: true);
                context.SetSkill(arg1: new[] {1358}, arg2: true);
                context.SetSkill(arg1: new[] {1359}, arg2: true);
                context.SetSkill(arg1: new[] {1360}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬09대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬09대기 : TriggerState {
            internal State스킬09대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1343}, arg2: false);
                context.SetSkill(arg1: new[] {1344}, arg2: false);
                context.SetSkill(arg1: new[] {1345}, arg2: false);
                context.SetSkill(arg1: new[] {1346}, arg2: false);
                context.SetSkill(arg1: new[] {1347}, arg2: false);
                context.SetSkill(arg1: new[] {1348}, arg2: false);
                context.SetSkill(arg1: new[] {1349}, arg2: false);
                context.SetSkill(arg1: new[] {1350}, arg2: false);
                context.SetSkill(arg1: new[] {1351}, arg2: false);
                context.SetSkill(arg1: new[] {1352}, arg2: false);
                context.SetSkill(arg1: new[] {1353}, arg2: false);
                context.SetSkill(arg1: new[] {1354}, arg2: false);
                context.SetSkill(arg1: new[] {1355}, arg2: false);
                context.SetSkill(arg1: new[] {1356}, arg2: false);
                context.SetSkill(arg1: new[] {1357}, arg2: false);
                context.SetSkill(arg1: new[] {1358}, arg2: false);
                context.SetSkill(arg1: new[] {1359}, arg2: false);
                context.SetSkill(arg1: new[] {1360}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬09 : TriggerState {
            internal State스킬09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1349}, arg2: true);
                context.SetSkill(arg1: new[] {1350}, arg2: true);
                context.SetSkill(arg1: new[] {1351}, arg2: true);
                context.SetSkill(arg1: new[] {1352}, arg2: true);
                context.SetSkill(arg1: new[] {1353}, arg2: true);
                context.SetSkill(arg1: new[] {1354}, arg2: true);
                context.SetSkill(arg1: new[] {1355}, arg2: true);
                context.SetSkill(arg1: new[] {1356}, arg2: true);
                context.SetSkill(arg1: new[] {1357}, arg2: true);
                context.SetSkill(arg1: new[] {1358}, arg2: true);
                context.SetSkill(arg1: new[] {1359}, arg2: true);
                context.SetSkill(arg1: new[] {1360}, arg2: true);
                context.SetSkill(arg1: new[] {1361}, arg2: true);
                context.SetSkill(arg1: new[] {1362}, arg2: true);
                context.SetSkill(arg1: new[] {1363}, arg2: true);
                context.SetSkill(arg1: new[] {1364}, arg2: true);
                context.SetSkill(arg1: new[] {1365}, arg2: true);
                context.SetSkill(arg1: new[] {1366}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬10대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬10대기 : TriggerState {
            internal State스킬10대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1349}, arg2: false);
                context.SetSkill(arg1: new[] {1350}, arg2: false);
                context.SetSkill(arg1: new[] {1351}, arg2: false);
                context.SetSkill(arg1: new[] {1352}, arg2: false);
                context.SetSkill(arg1: new[] {1353}, arg2: false);
                context.SetSkill(arg1: new[] {1354}, arg2: false);
                context.SetSkill(arg1: new[] {1355}, arg2: false);
                context.SetSkill(arg1: new[] {1356}, arg2: false);
                context.SetSkill(arg1: new[] {1357}, arg2: false);
                context.SetSkill(arg1: new[] {1358}, arg2: false);
                context.SetSkill(arg1: new[] {1359}, arg2: false);
                context.SetSkill(arg1: new[] {1360}, arg2: false);
                context.SetSkill(arg1: new[] {1361}, arg2: false);
                context.SetSkill(arg1: new[] {1362}, arg2: false);
                context.SetSkill(arg1: new[] {1363}, arg2: false);
                context.SetSkill(arg1: new[] {1364}, arg2: false);
                context.SetSkill(arg1: new[] {1365}, arg2: false);
                context.SetSkill(arg1: new[] {1366}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬10 : TriggerState {
            internal State스킬10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1355}, arg2: true);
                context.SetSkill(arg1: new[] {1356}, arg2: true);
                context.SetSkill(arg1: new[] {1357}, arg2: true);
                context.SetSkill(arg1: new[] {1358}, arg2: true);
                context.SetSkill(arg1: new[] {1359}, arg2: true);
                context.SetSkill(arg1: new[] {1360}, arg2: true);
                context.SetSkill(arg1: new[] {1361}, arg2: true);
                context.SetSkill(arg1: new[] {1362}, arg2: true);
                context.SetSkill(arg1: new[] {1363}, arg2: true);
                context.SetSkill(arg1: new[] {1364}, arg2: true);
                context.SetSkill(arg1: new[] {1365}, arg2: true);
                context.SetSkill(arg1: new[] {1366}, arg2: true);
                context.SetSkill(arg1: new[] {1367}, arg2: true);
                context.SetSkill(arg1: new[] {1368}, arg2: true);
                context.SetSkill(arg1: new[] {1369}, arg2: true);
                context.SetSkill(arg1: new[] {1370}, arg2: true);
                context.SetSkill(arg1: new[] {1371}, arg2: true);
                context.SetSkill(arg1: new[] {1372}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬11대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬11대기 : TriggerState {
            internal State스킬11대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1355}, arg2: false);
                context.SetSkill(arg1: new[] {1356}, arg2: false);
                context.SetSkill(arg1: new[] {1357}, arg2: false);
                context.SetSkill(arg1: new[] {1358}, arg2: false);
                context.SetSkill(arg1: new[] {1359}, arg2: false);
                context.SetSkill(arg1: new[] {1360}, arg2: false);
                context.SetSkill(arg1: new[] {1361}, arg2: false);
                context.SetSkill(arg1: new[] {1362}, arg2: false);
                context.SetSkill(arg1: new[] {1363}, arg2: false);
                context.SetSkill(arg1: new[] {1364}, arg2: false);
                context.SetSkill(arg1: new[] {1365}, arg2: false);
                context.SetSkill(arg1: new[] {1366}, arg2: false);
                context.SetSkill(arg1: new[] {1367}, arg2: false);
                context.SetSkill(arg1: new[] {1368}, arg2: false);
                context.SetSkill(arg1: new[] {1369}, arg2: false);
                context.SetSkill(arg1: new[] {1370}, arg2: false);
                context.SetSkill(arg1: new[] {1371}, arg2: false);
                context.SetSkill(arg1: new[] {1372}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬11 : TriggerState {
            internal State스킬11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1361}, arg2: true);
                context.SetSkill(arg1: new[] {1362}, arg2: true);
                context.SetSkill(arg1: new[] {1363}, arg2: true);
                context.SetSkill(arg1: new[] {1364}, arg2: true);
                context.SetSkill(arg1: new[] {1365}, arg2: true);
                context.SetSkill(arg1: new[] {1366}, arg2: true);
                context.SetSkill(arg1: new[] {1367}, arg2: true);
                context.SetSkill(arg1: new[] {1368}, arg2: true);
                context.SetSkill(arg1: new[] {1369}, arg2: true);
                context.SetSkill(arg1: new[] {1370}, arg2: true);
                context.SetSkill(arg1: new[] {1371}, arg2: true);
                context.SetSkill(arg1: new[] {1372}, arg2: true);
                context.SetSkill(arg1: new[] {1373}, arg2: true);
                context.SetSkill(arg1: new[] {1374}, arg2: true);
                context.SetSkill(arg1: new[] {1375}, arg2: true);
                context.SetSkill(arg1: new[] {1376}, arg2: true);
                context.SetSkill(arg1: new[] {1377}, arg2: true);
                context.SetSkill(arg1: new[] {1378}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬12대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬12대기 : TriggerState {
            internal State스킬12대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1361}, arg2: false);
                context.SetSkill(arg1: new[] {1362}, arg2: false);
                context.SetSkill(arg1: new[] {1363}, arg2: false);
                context.SetSkill(arg1: new[] {1364}, arg2: false);
                context.SetSkill(arg1: new[] {1365}, arg2: false);
                context.SetSkill(arg1: new[] {1366}, arg2: false);
                context.SetSkill(arg1: new[] {1367}, arg2: false);
                context.SetSkill(arg1: new[] {1368}, arg2: false);
                context.SetSkill(arg1: new[] {1369}, arg2: false);
                context.SetSkill(arg1: new[] {1370}, arg2: false);
                context.SetSkill(arg1: new[] {1371}, arg2: false);
                context.SetSkill(arg1: new[] {1372}, arg2: false);
                context.SetSkill(arg1: new[] {1373}, arg2: false);
                context.SetSkill(arg1: new[] {1374}, arg2: false);
                context.SetSkill(arg1: new[] {1375}, arg2: false);
                context.SetSkill(arg1: new[] {1376}, arg2: false);
                context.SetSkill(arg1: new[] {1377}, arg2: false);
                context.SetSkill(arg1: new[] {1378}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬12 : TriggerState {
            internal State스킬12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1367}, arg2: true);
                context.SetSkill(arg1: new[] {1368}, arg2: true);
                context.SetSkill(arg1: new[] {1369}, arg2: true);
                context.SetSkill(arg1: new[] {1370}, arg2: true);
                context.SetSkill(arg1: new[] {1371}, arg2: true);
                context.SetSkill(arg1: new[] {1372}, arg2: true);
                context.SetSkill(arg1: new[] {1373}, arg2: true);
                context.SetSkill(arg1: new[] {1374}, arg2: true);
                context.SetSkill(arg1: new[] {1375}, arg2: true);
                context.SetSkill(arg1: new[] {1376}, arg2: true);
                context.SetSkill(arg1: new[] {1377}, arg2: true);
                context.SetSkill(arg1: new[] {1378}, arg2: true);
                context.SetSkill(arg1: new[] {1379}, arg2: true);
                context.SetSkill(arg1: new[] {1380}, arg2: true);
                context.SetSkill(arg1: new[] {1381}, arg2: true);
                context.SetSkill(arg1: new[] {1382}, arg2: true);
                context.SetSkill(arg1: new[] {1383}, arg2: true);
                context.SetSkill(arg1: new[] {1384}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬13대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬13대기 : TriggerState {
            internal State스킬13대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1367}, arg2: false);
                context.SetSkill(arg1: new[] {1368}, arg2: false);
                context.SetSkill(arg1: new[] {1369}, arg2: false);
                context.SetSkill(arg1: new[] {1370}, arg2: false);
                context.SetSkill(arg1: new[] {1371}, arg2: false);
                context.SetSkill(arg1: new[] {1372}, arg2: false);
                context.SetSkill(arg1: new[] {1373}, arg2: false);
                context.SetSkill(arg1: new[] {1374}, arg2: false);
                context.SetSkill(arg1: new[] {1375}, arg2: false);
                context.SetSkill(arg1: new[] {1376}, arg2: false);
                context.SetSkill(arg1: new[] {1377}, arg2: false);
                context.SetSkill(arg1: new[] {1378}, arg2: false);
                context.SetSkill(arg1: new[] {1379}, arg2: false);
                context.SetSkill(arg1: new[] {1380}, arg2: false);
                context.SetSkill(arg1: new[] {1381}, arg2: false);
                context.SetSkill(arg1: new[] {1382}, arg2: false);
                context.SetSkill(arg1: new[] {1383}, arg2: false);
                context.SetSkill(arg1: new[] {1384}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬13 : TriggerState {
            internal State스킬13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1373}, arg2: true);
                context.SetSkill(arg1: new[] {1374}, arg2: true);
                context.SetSkill(arg1: new[] {1375}, arg2: true);
                context.SetSkill(arg1: new[] {1376}, arg2: true);
                context.SetSkill(arg1: new[] {1377}, arg2: true);
                context.SetSkill(arg1: new[] {1378}, arg2: true);
                context.SetSkill(arg1: new[] {1379}, arg2: true);
                context.SetSkill(arg1: new[] {1380}, arg2: true);
                context.SetSkill(arg1: new[] {1381}, arg2: true);
                context.SetSkill(arg1: new[] {1382}, arg2: true);
                context.SetSkill(arg1: new[] {1383}, arg2: true);
                context.SetSkill(arg1: new[] {1384}, arg2: true);
                context.SetSkill(arg1: new[] {1385}, arg2: true);
                context.SetSkill(arg1: new[] {1386}, arg2: true);
                context.SetSkill(arg1: new[] {1387}, arg2: true);
                context.SetSkill(arg1: new[] {1388}, arg2: true);
                context.SetSkill(arg1: new[] {1389}, arg2: true);
                context.SetSkill(arg1: new[] {1390}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬14대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬14대기 : TriggerState {
            internal State스킬14대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1373}, arg2: false);
                context.SetSkill(arg1: new[] {1374}, arg2: false);
                context.SetSkill(arg1: new[] {1375}, arg2: false);
                context.SetSkill(arg1: new[] {1376}, arg2: false);
                context.SetSkill(arg1: new[] {1377}, arg2: false);
                context.SetSkill(arg1: new[] {1378}, arg2: false);
                context.SetSkill(arg1: new[] {1379}, arg2: false);
                context.SetSkill(arg1: new[] {1380}, arg2: false);
                context.SetSkill(arg1: new[] {1381}, arg2: false);
                context.SetSkill(arg1: new[] {1382}, arg2: false);
                context.SetSkill(arg1: new[] {1383}, arg2: false);
                context.SetSkill(arg1: new[] {1384}, arg2: false);
                context.SetSkill(arg1: new[] {1385}, arg2: false);
                context.SetSkill(arg1: new[] {1386}, arg2: false);
                context.SetSkill(arg1: new[] {1387}, arg2: false);
                context.SetSkill(arg1: new[] {1388}, arg2: false);
                context.SetSkill(arg1: new[] {1389}, arg2: false);
                context.SetSkill(arg1: new[] {1390}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬14(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬14 : TriggerState {
            internal State스킬14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1379}, arg2: true);
                context.SetSkill(arg1: new[] {1380}, arg2: true);
                context.SetSkill(arg1: new[] {1381}, arg2: true);
                context.SetSkill(arg1: new[] {1382}, arg2: true);
                context.SetSkill(arg1: new[] {1383}, arg2: true);
                context.SetSkill(arg1: new[] {1384}, arg2: true);
                context.SetSkill(arg1: new[] {1385}, arg2: true);
                context.SetSkill(arg1: new[] {1386}, arg2: true);
                context.SetSkill(arg1: new[] {1387}, arg2: true);
                context.SetSkill(arg1: new[] {1388}, arg2: true);
                context.SetSkill(arg1: new[] {1389}, arg2: true);
                context.SetSkill(arg1: new[] {1390}, arg2: true);
                context.SetSkill(arg1: new[] {1391}, arg2: true);
                context.SetSkill(arg1: new[] {1392}, arg2: true);
                context.SetSkill(arg1: new[] {1393}, arg2: true);
                context.SetSkill(arg1: new[] {1394}, arg2: true);
                context.SetSkill(arg1: new[] {1395}, arg2: true);
                context.SetSkill(arg1: new[] {1396}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬15대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬15대기 : TriggerState {
            internal State스킬15대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1379}, arg2: false);
                context.SetSkill(arg1: new[] {1380}, arg2: false);
                context.SetSkill(arg1: new[] {1381}, arg2: false);
                context.SetSkill(arg1: new[] {1382}, arg2: false);
                context.SetSkill(arg1: new[] {1383}, arg2: false);
                context.SetSkill(arg1: new[] {1384}, arg2: false);
                context.SetSkill(arg1: new[] {1385}, arg2: false);
                context.SetSkill(arg1: new[] {1386}, arg2: false);
                context.SetSkill(arg1: new[] {1387}, arg2: false);
                context.SetSkill(arg1: new[] {1388}, arg2: false);
                context.SetSkill(arg1: new[] {1389}, arg2: false);
                context.SetSkill(arg1: new[] {1390}, arg2: false);
                context.SetSkill(arg1: new[] {1391}, arg2: false);
                context.SetSkill(arg1: new[] {1392}, arg2: false);
                context.SetSkill(arg1: new[] {1393}, arg2: false);
                context.SetSkill(arg1: new[] {1394}, arg2: false);
                context.SetSkill(arg1: new[] {1395}, arg2: false);
                context.SetSkill(arg1: new[] {1396}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬15(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬15 : TriggerState {
            internal State스킬15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1385}, arg2: true);
                context.SetSkill(arg1: new[] {1386}, arg2: true);
                context.SetSkill(arg1: new[] {1387}, arg2: true);
                context.SetSkill(arg1: new[] {1388}, arg2: true);
                context.SetSkill(arg1: new[] {1389}, arg2: true);
                context.SetSkill(arg1: new[] {1390}, arg2: true);
                context.SetSkill(arg1: new[] {1391}, arg2: true);
                context.SetSkill(arg1: new[] {1392}, arg2: true);
                context.SetSkill(arg1: new[] {1393}, arg2: true);
                context.SetSkill(arg1: new[] {1394}, arg2: true);
                context.SetSkill(arg1: new[] {1395}, arg2: true);
                context.SetSkill(arg1: new[] {1396}, arg2: true);
                context.SetSkill(arg1: new[] {1397}, arg2: true);
                context.SetSkill(arg1: new[] {1398}, arg2: true);
                context.SetSkill(arg1: new[] {1399}, arg2: true);
                context.SetSkill(arg1: new[] {1400}, arg2: true);
                context.SetSkill(arg1: new[] {1401}, arg2: true);
                context.SetSkill(arg1: new[] {1402}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬16대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬16대기 : TriggerState {
            internal State스킬16대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1385}, arg2: false);
                context.SetSkill(arg1: new[] {1386}, arg2: false);
                context.SetSkill(arg1: new[] {1387}, arg2: false);
                context.SetSkill(arg1: new[] {1388}, arg2: false);
                context.SetSkill(arg1: new[] {1389}, arg2: false);
                context.SetSkill(arg1: new[] {1390}, arg2: false);
                context.SetSkill(arg1: new[] {1391}, arg2: false);
                context.SetSkill(arg1: new[] {1392}, arg2: false);
                context.SetSkill(arg1: new[] {1393}, arg2: false);
                context.SetSkill(arg1: new[] {1394}, arg2: false);
                context.SetSkill(arg1: new[] {1395}, arg2: false);
                context.SetSkill(arg1: new[] {1396}, arg2: false);
                context.SetSkill(arg1: new[] {1397}, arg2: false);
                context.SetSkill(arg1: new[] {1398}, arg2: false);
                context.SetSkill(arg1: new[] {1399}, arg2: false);
                context.SetSkill(arg1: new[] {1400}, arg2: false);
                context.SetSkill(arg1: new[] {1401}, arg2: false);
                context.SetSkill(arg1: new[] {1402}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬16(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬16 : TriggerState {
            internal State스킬16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1391}, arg2: true);
                context.SetSkill(arg1: new[] {1392}, arg2: true);
                context.SetSkill(arg1: new[] {1393}, arg2: true);
                context.SetSkill(arg1: new[] {1394}, arg2: true);
                context.SetSkill(arg1: new[] {1395}, arg2: true);
                context.SetSkill(arg1: new[] {1396}, arg2: true);
                context.SetSkill(arg1: new[] {1397}, arg2: true);
                context.SetSkill(arg1: new[] {1398}, arg2: true);
                context.SetSkill(arg1: new[] {1399}, arg2: true);
                context.SetSkill(arg1: new[] {1400}, arg2: true);
                context.SetSkill(arg1: new[] {1401}, arg2: true);
                context.SetSkill(arg1: new[] {1402}, arg2: true);
                context.SetSkill(arg1: new[] {1403}, arg2: true);
                context.SetSkill(arg1: new[] {1404}, arg2: true);
                context.SetSkill(arg1: new[] {1405}, arg2: true);
                context.SetSkill(arg1: new[] {1406}, arg2: true);
                context.SetSkill(arg1: new[] {1407}, arg2: true);
                context.SetSkill(arg1: new[] {1408}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬17대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬17대기 : TriggerState {
            internal State스킬17대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1391}, arg2: false);
                context.SetSkill(arg1: new[] {1392}, arg2: false);
                context.SetSkill(arg1: new[] {1393}, arg2: false);
                context.SetSkill(arg1: new[] {1394}, arg2: false);
                context.SetSkill(arg1: new[] {1395}, arg2: false);
                context.SetSkill(arg1: new[] {1396}, arg2: false);
                context.SetSkill(arg1: new[] {1397}, arg2: false);
                context.SetSkill(arg1: new[] {1398}, arg2: false);
                context.SetSkill(arg1: new[] {1399}, arg2: false);
                context.SetSkill(arg1: new[] {1400}, arg2: false);
                context.SetSkill(arg1: new[] {1401}, arg2: false);
                context.SetSkill(arg1: new[] {1402}, arg2: false);
                context.SetSkill(arg1: new[] {1403}, arg2: false);
                context.SetSkill(arg1: new[] {1404}, arg2: false);
                context.SetSkill(arg1: new[] {1405}, arg2: false);
                context.SetSkill(arg1: new[] {1406}, arg2: false);
                context.SetSkill(arg1: new[] {1407}, arg2: false);
                context.SetSkill(arg1: new[] {1408}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬17(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬17 : TriggerState {
            internal State스킬17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1391}, arg2: true);
                context.SetSkill(arg1: new[] {1392}, arg2: true);
                context.SetSkill(arg1: new[] {1393}, arg2: true);
                context.SetSkill(arg1: new[] {1394}, arg2: true);
                context.SetSkill(arg1: new[] {1395}, arg2: true);
                context.SetSkill(arg1: new[] {1396}, arg2: true);
                context.SetSkill(arg1: new[] {1397}, arg2: true);
                context.SetSkill(arg1: new[] {1398}, arg2: true);
                context.SetSkill(arg1: new[] {1399}, arg2: true);
                context.SetSkill(arg1: new[] {1400}, arg2: true);
                context.SetSkill(arg1: new[] {1401}, arg2: true);
                context.SetSkill(arg1: new[] {1402}, arg2: true);
                context.SetSkill(arg1: new[] {1403}, arg2: true);
                context.SetSkill(arg1: new[] {1404}, arg2: true);
                context.SetSkill(arg1: new[] {1405}, arg2: true);
                context.SetSkill(arg1: new[] {1406}, arg2: true);
                context.SetSkill(arg1: new[] {1407}, arg2: true);
                context.SetSkill(arg1: new[] {1408}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬18대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬18대기 : TriggerState {
            internal State스킬18대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1391}, arg2: false);
                context.SetSkill(arg1: new[] {1392}, arg2: false);
                context.SetSkill(arg1: new[] {1393}, arg2: false);
                context.SetSkill(arg1: new[] {1394}, arg2: false);
                context.SetSkill(arg1: new[] {1395}, arg2: false);
                context.SetSkill(arg1: new[] {1396}, arg2: false);
                context.SetSkill(arg1: new[] {1397}, arg2: false);
                context.SetSkill(arg1: new[] {1398}, arg2: false);
                context.SetSkill(arg1: new[] {1399}, arg2: false);
                context.SetSkill(arg1: new[] {1400}, arg2: false);
                context.SetSkill(arg1: new[] {1401}, arg2: false);
                context.SetSkill(arg1: new[] {1402}, arg2: false);
                context.SetSkill(arg1: new[] {1403}, arg2: false);
                context.SetSkill(arg1: new[] {1404}, arg2: false);
                context.SetSkill(arg1: new[] {1405}, arg2: false);
                context.SetSkill(arg1: new[] {1406}, arg2: false);
                context.SetSkill(arg1: new[] {1407}, arg2: false);
                context.SetSkill(arg1: new[] {1408}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬18(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬18 : TriggerState {
            internal State스킬18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1397}, arg2: true);
                context.SetSkill(arg1: new[] {1398}, arg2: true);
                context.SetSkill(arg1: new[] {1399}, arg2: true);
                context.SetSkill(arg1: new[] {1400}, arg2: true);
                context.SetSkill(arg1: new[] {1401}, arg2: true);
                context.SetSkill(arg1: new[] {1402}, arg2: true);
                context.SetSkill(arg1: new[] {1403}, arg2: true);
                context.SetSkill(arg1: new[] {1404}, arg2: true);
                context.SetSkill(arg1: new[] {1405}, arg2: true);
                context.SetSkill(arg1: new[] {1406}, arg2: true);
                context.SetSkill(arg1: new[] {1407}, arg2: true);
                context.SetSkill(arg1: new[] {1408}, arg2: true);
                context.SetSkill(arg1: new[] {1409}, arg2: true);
                context.SetSkill(arg1: new[] {1410}, arg2: true);
                context.SetSkill(arg1: new[] {1411}, arg2: true);
                context.SetSkill(arg1: new[] {1412}, arg2: true);
                context.SetSkill(arg1: new[] {1413}, arg2: true);
                context.SetSkill(arg1: new[] {1414}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬19대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬19대기 : TriggerState {
            internal State스킬19대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1397}, arg2: false);
                context.SetSkill(arg1: new[] {1398}, arg2: false);
                context.SetSkill(arg1: new[] {1399}, arg2: false);
                context.SetSkill(arg1: new[] {1400}, arg2: false);
                context.SetSkill(arg1: new[] {1401}, arg2: false);
                context.SetSkill(arg1: new[] {1402}, arg2: false);
                context.SetSkill(arg1: new[] {1403}, arg2: false);
                context.SetSkill(arg1: new[] {1404}, arg2: false);
                context.SetSkill(arg1: new[] {1405}, arg2: false);
                context.SetSkill(arg1: new[] {1406}, arg2: false);
                context.SetSkill(arg1: new[] {1407}, arg2: false);
                context.SetSkill(arg1: new[] {1408}, arg2: false);
                context.SetSkill(arg1: new[] {1409}, arg2: false);
                context.SetSkill(arg1: new[] {1410}, arg2: false);
                context.SetSkill(arg1: new[] {1411}, arg2: false);
                context.SetSkill(arg1: new[] {1412}, arg2: false);
                context.SetSkill(arg1: new[] {1413}, arg2: false);
                context.SetSkill(arg1: new[] {1414}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬19(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬19 : TriggerState {
            internal State스킬19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1403}, arg2: true);
                context.SetSkill(arg1: new[] {1404}, arg2: true);
                context.SetSkill(arg1: new[] {1405}, arg2: true);
                context.SetSkill(arg1: new[] {1406}, arg2: true);
                context.SetSkill(arg1: new[] {1407}, arg2: true);
                context.SetSkill(arg1: new[] {1408}, arg2: true);
                context.SetSkill(arg1: new[] {1409}, arg2: true);
                context.SetSkill(arg1: new[] {1410}, arg2: true);
                context.SetSkill(arg1: new[] {1411}, arg2: true);
                context.SetSkill(arg1: new[] {1412}, arg2: true);
                context.SetSkill(arg1: new[] {1413}, arg2: true);
                context.SetSkill(arg1: new[] {1414}, arg2: true);
                context.SetSkill(arg1: new[] {1409}, arg2: true);
                context.SetSkill(arg1: new[] {1410}, arg2: true);
                context.SetSkill(arg1: new[] {1411}, arg2: true);
                context.SetSkill(arg1: new[] {1412}, arg2: true);
                context.SetSkill(arg1: new[] {1413}, arg2: true);
                context.SetSkill(arg1: new[] {1414}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬20대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬20대기 : TriggerState {
            internal State스킬20대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1403}, arg2: false);
                context.SetSkill(arg1: new[] {1404}, arg2: false);
                context.SetSkill(arg1: new[] {1405}, arg2: false);
                context.SetSkill(arg1: new[] {1406}, arg2: false);
                context.SetSkill(arg1: new[] {1407}, arg2: false);
                context.SetSkill(arg1: new[] {1408}, arg2: false);
                context.SetSkill(arg1: new[] {1409}, arg2: false);
                context.SetSkill(arg1: new[] {1410}, arg2: false);
                context.SetSkill(arg1: new[] {1411}, arg2: false);
                context.SetSkill(arg1: new[] {1412}, arg2: false);
                context.SetSkill(arg1: new[] {1413}, arg2: false);
                context.SetSkill(arg1: new[] {1414}, arg2: false);
                context.SetSkill(arg1: new[] {1415}, arg2: false);
                context.SetSkill(arg1: new[] {1416}, arg2: false);
                context.SetSkill(arg1: new[] {1417}, arg2: false);
                context.SetSkill(arg1: new[] {1418}, arg2: false);
                context.SetSkill(arg1: new[] {1419}, arg2: false);
                context.SetSkill(arg1: new[] {1420}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬20(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬20 : TriggerState {
            internal State스킬20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1409}, arg2: true);
                context.SetSkill(arg1: new[] {1410}, arg2: true);
                context.SetSkill(arg1: new[] {1411}, arg2: true);
                context.SetSkill(arg1: new[] {1412}, arg2: true);
                context.SetSkill(arg1: new[] {1413}, arg2: true);
                context.SetSkill(arg1: new[] {1414}, arg2: true);
                context.SetSkill(arg1: new[] {1415}, arg2: true);
                context.SetSkill(arg1: new[] {1416}, arg2: true);
                context.SetSkill(arg1: new[] {1417}, arg2: true);
                context.SetSkill(arg1: new[] {1418}, arg2: true);
                context.SetSkill(arg1: new[] {1419}, arg2: true);
                context.SetSkill(arg1: new[] {1420}, arg2: true);
                context.SetSkill(arg1: new[] {1421}, arg2: true);
                context.SetSkill(arg1: new[] {1422}, arg2: true);
                context.SetSkill(arg1: new[] {1423}, arg2: true);
                context.SetSkill(arg1: new[] {1424}, arg2: true);
                context.SetSkill(arg1: new[] {1425}, arg2: true);
                context.SetSkill(arg1: new[] {1426}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬21대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬21대기 : TriggerState {
            internal State스킬21대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1409}, arg2: false);
                context.SetSkill(arg1: new[] {1410}, arg2: false);
                context.SetSkill(arg1: new[] {1411}, arg2: false);
                context.SetSkill(arg1: new[] {1412}, arg2: false);
                context.SetSkill(arg1: new[] {1413}, arg2: false);
                context.SetSkill(arg1: new[] {1414}, arg2: false);
                context.SetSkill(arg1: new[] {1415}, arg2: false);
                context.SetSkill(arg1: new[] {1416}, arg2: false);
                context.SetSkill(arg1: new[] {1417}, arg2: false);
                context.SetSkill(arg1: new[] {1418}, arg2: false);
                context.SetSkill(arg1: new[] {1419}, arg2: false);
                context.SetSkill(arg1: new[] {1420}, arg2: false);
                context.SetSkill(arg1: new[] {1421}, arg2: false);
                context.SetSkill(arg1: new[] {1422}, arg2: false);
                context.SetSkill(arg1: new[] {1423}, arg2: false);
                context.SetSkill(arg1: new[] {1424}, arg2: false);
                context.SetSkill(arg1: new[] {1425}, arg2: false);
                context.SetSkill(arg1: new[] {1426}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬21(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬21 : TriggerState {
            internal State스킬21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1415}, arg2: true);
                context.SetSkill(arg1: new[] {1416}, arg2: true);
                context.SetSkill(arg1: new[] {1417}, arg2: true);
                context.SetSkill(arg1: new[] {1418}, arg2: true);
                context.SetSkill(arg1: new[] {1419}, arg2: true);
                context.SetSkill(arg1: new[] {1420}, arg2: true);
                context.SetSkill(arg1: new[] {1421}, arg2: true);
                context.SetSkill(arg1: new[] {1422}, arg2: true);
                context.SetSkill(arg1: new[] {1423}, arg2: true);
                context.SetSkill(arg1: new[] {1424}, arg2: true);
                context.SetSkill(arg1: new[] {1425}, arg2: true);
                context.SetSkill(arg1: new[] {1426}, arg2: true);
                context.SetSkill(arg1: new[] {1427}, arg2: true);
                context.SetSkill(arg1: new[] {1428}, arg2: true);
                context.SetSkill(arg1: new[] {1429}, arg2: true);
                context.SetSkill(arg1: new[] {1430}, arg2: true);
                context.SetSkill(arg1: new[] {1431}, arg2: true);
                context.SetSkill(arg1: new[] {1432}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬22대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬22대기 : TriggerState {
            internal State스킬22대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1415}, arg2: false);
                context.SetSkill(arg1: new[] {1416}, arg2: false);
                context.SetSkill(arg1: new[] {1417}, arg2: false);
                context.SetSkill(arg1: new[] {1418}, arg2: false);
                context.SetSkill(arg1: new[] {1419}, arg2: false);
                context.SetSkill(arg1: new[] {1420}, arg2: false);
                context.SetSkill(arg1: new[] {1421}, arg2: false);
                context.SetSkill(arg1: new[] {1422}, arg2: false);
                context.SetSkill(arg1: new[] {1423}, arg2: false);
                context.SetSkill(arg1: new[] {1424}, arg2: false);
                context.SetSkill(arg1: new[] {1425}, arg2: false);
                context.SetSkill(arg1: new[] {1426}, arg2: false);
                context.SetSkill(arg1: new[] {1427}, arg2: false);
                context.SetSkill(arg1: new[] {1428}, arg2: false);
                context.SetSkill(arg1: new[] {1429}, arg2: false);
                context.SetSkill(arg1: new[] {1430}, arg2: false);
                context.SetSkill(arg1: new[] {1431}, arg2: false);
                context.SetSkill(arg1: new[] {1432}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬22(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬22 : TriggerState {
            internal State스킬22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1421}, arg2: true);
                context.SetSkill(arg1: new[] {1422}, arg2: true);
                context.SetSkill(arg1: new[] {1423}, arg2: true);
                context.SetSkill(arg1: new[] {1424}, arg2: true);
                context.SetSkill(arg1: new[] {1425}, arg2: true);
                context.SetSkill(arg1: new[] {1426}, arg2: true);
                context.SetSkill(arg1: new[] {1427}, arg2: true);
                context.SetSkill(arg1: new[] {1428}, arg2: true);
                context.SetSkill(arg1: new[] {1429}, arg2: true);
                context.SetSkill(arg1: new[] {1430}, arg2: true);
                context.SetSkill(arg1: new[] {1431}, arg2: true);
                context.SetSkill(arg1: new[] {1432}, arg2: true);
                context.SetSkill(arg1: new[] {1433}, arg2: true);
                context.SetSkill(arg1: new[] {1434}, arg2: true);
                context.SetSkill(arg1: new[] {1435}, arg2: true);
                context.SetSkill(arg1: new[] {1436}, arg2: true);
                context.SetSkill(arg1: new[] {1437}, arg2: true);
                context.SetSkill(arg1: new[] {1438}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬23대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬23대기 : TriggerState {
            internal State스킬23대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1421}, arg2: false);
                context.SetSkill(arg1: new[] {1422}, arg2: false);
                context.SetSkill(arg1: new[] {1423}, arg2: false);
                context.SetSkill(arg1: new[] {1424}, arg2: false);
                context.SetSkill(arg1: new[] {1425}, arg2: false);
                context.SetSkill(arg1: new[] {1426}, arg2: false);
                context.SetSkill(arg1: new[] {1427}, arg2: false);
                context.SetSkill(arg1: new[] {1428}, arg2: false);
                context.SetSkill(arg1: new[] {1429}, arg2: false);
                context.SetSkill(arg1: new[] {1430}, arg2: false);
                context.SetSkill(arg1: new[] {1431}, arg2: false);
                context.SetSkill(arg1: new[] {1432}, arg2: false);
                context.SetSkill(arg1: new[] {1433}, arg2: false);
                context.SetSkill(arg1: new[] {1434}, arg2: false);
                context.SetSkill(arg1: new[] {1435}, arg2: false);
                context.SetSkill(arg1: new[] {1436}, arg2: false);
                context.SetSkill(arg1: new[] {1437}, arg2: false);
                context.SetSkill(arg1: new[] {1438}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬23(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬23 : TriggerState {
            internal State스킬23(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1427}, arg2: true);
                context.SetSkill(arg1: new[] {1428}, arg2: true);
                context.SetSkill(arg1: new[] {1429}, arg2: true);
                context.SetSkill(arg1: new[] {1430}, arg2: true);
                context.SetSkill(arg1: new[] {1431}, arg2: true);
                context.SetSkill(arg1: new[] {1432}, arg2: true);
                context.SetSkill(arg1: new[] {1433}, arg2: true);
                context.SetSkill(arg1: new[] {1434}, arg2: true);
                context.SetSkill(arg1: new[] {1435}, arg2: true);
                context.SetSkill(arg1: new[] {1436}, arg2: true);
                context.SetSkill(arg1: new[] {1437}, arg2: true);
                context.SetSkill(arg1: new[] {1438}, arg2: true);
                context.SetSkill(arg1: new[] {1439}, arg2: true);
                context.SetSkill(arg1: new[] {1440}, arg2: true);
                context.SetSkill(arg1: new[] {1441}, arg2: true);
                context.SetSkill(arg1: new[] {1442}, arg2: true);
                context.SetSkill(arg1: new[] {1443}, arg2: true);
                context.SetSkill(arg1: new[] {1444}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬24대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬24대기 : TriggerState {
            internal State스킬24대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1427}, arg2: false);
                context.SetSkill(arg1: new[] {1428}, arg2: false);
                context.SetSkill(arg1: new[] {1429}, arg2: false);
                context.SetSkill(arg1: new[] {1430}, arg2: false);
                context.SetSkill(arg1: new[] {1431}, arg2: false);
                context.SetSkill(arg1: new[] {1432}, arg2: false);
                context.SetSkill(arg1: new[] {1433}, arg2: false);
                context.SetSkill(arg1: new[] {1434}, arg2: false);
                context.SetSkill(arg1: new[] {1435}, arg2: false);
                context.SetSkill(arg1: new[] {1436}, arg2: false);
                context.SetSkill(arg1: new[] {1437}, arg2: false);
                context.SetSkill(arg1: new[] {1438}, arg2: false);
                context.SetSkill(arg1: new[] {1439}, arg2: false);
                context.SetSkill(arg1: new[] {1440}, arg2: false);
                context.SetSkill(arg1: new[] {1441}, arg2: false);
                context.SetSkill(arg1: new[] {1442}, arg2: false);
                context.SetSkill(arg1: new[] {1443}, arg2: false);
                context.SetSkill(arg1: new[] {1444}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬24(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬24 : TriggerState {
            internal State스킬24(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1433}, arg2: true);
                context.SetSkill(arg1: new[] {1434}, arg2: true);
                context.SetSkill(arg1: new[] {1435}, arg2: true);
                context.SetSkill(arg1: new[] {1436}, arg2: true);
                context.SetSkill(arg1: new[] {1437}, arg2: true);
                context.SetSkill(arg1: new[] {1438}, arg2: true);
                context.SetSkill(arg1: new[] {1439}, arg2: true);
                context.SetSkill(arg1: new[] {1440}, arg2: true);
                context.SetSkill(arg1: new[] {1441}, arg2: true);
                context.SetSkill(arg1: new[] {1442}, arg2: true);
                context.SetSkill(arg1: new[] {1443}, arg2: true);
                context.SetSkill(arg1: new[] {1444}, arg2: true);
                context.SetSkill(arg1: new[] {1445}, arg2: true);
                context.SetSkill(arg1: new[] {1446}, arg2: true);
                context.SetSkill(arg1: new[] {1447}, arg2: true);
                context.SetSkill(arg1: new[] {1448}, arg2: true);
                context.SetSkill(arg1: new[] {1449}, arg2: true);
                context.SetSkill(arg1: new[] {1450}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬25대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬25대기 : TriggerState {
            internal State스킬25대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1433}, arg2: false);
                context.SetSkill(arg1: new[] {1434}, arg2: false);
                context.SetSkill(arg1: new[] {1435}, arg2: false);
                context.SetSkill(arg1: new[] {1436}, arg2: false);
                context.SetSkill(arg1: new[] {1437}, arg2: false);
                context.SetSkill(arg1: new[] {1438}, arg2: false);
                context.SetSkill(arg1: new[] {1439}, arg2: false);
                context.SetSkill(arg1: new[] {1440}, arg2: false);
                context.SetSkill(arg1: new[] {1441}, arg2: false);
                context.SetSkill(arg1: new[] {1442}, arg2: false);
                context.SetSkill(arg1: new[] {1443}, arg2: false);
                context.SetSkill(arg1: new[] {1444}, arg2: false);
                context.SetSkill(arg1: new[] {1445}, arg2: false);
                context.SetSkill(arg1: new[] {1446}, arg2: false);
                context.SetSkill(arg1: new[] {1447}, arg2: false);
                context.SetSkill(arg1: new[] {1448}, arg2: false);
                context.SetSkill(arg1: new[] {1449}, arg2: false);
                context.SetSkill(arg1: new[] {1450}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬25(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬25 : TriggerState {
            internal State스킬25(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1439}, arg2: true);
                context.SetSkill(arg1: new[] {1440}, arg2: true);
                context.SetSkill(arg1: new[] {1441}, arg2: true);
                context.SetSkill(arg1: new[] {1442}, arg2: true);
                context.SetSkill(arg1: new[] {1443}, arg2: true);
                context.SetSkill(arg1: new[] {1444}, arg2: true);
                context.SetSkill(arg1: new[] {1445}, arg2: true);
                context.SetSkill(arg1: new[] {1446}, arg2: true);
                context.SetSkill(arg1: new[] {1447}, arg2: true);
                context.SetSkill(arg1: new[] {1448}, arg2: true);
                context.SetSkill(arg1: new[] {1449}, arg2: true);
                context.SetSkill(arg1: new[] {1450}, arg2: true);
                context.SetSkill(arg1: new[] {1451}, arg2: true);
                context.SetSkill(arg1: new[] {1452}, arg2: true);
                context.SetSkill(arg1: new[] {1453}, arg2: true);
                context.SetSkill(arg1: new[] {1454}, arg2: true);
                context.SetSkill(arg1: new[] {1455}, arg2: true);
                context.SetSkill(arg1: new[] {1456}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬26대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬26대기 : TriggerState {
            internal State스킬26대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1439}, arg2: false);
                context.SetSkill(arg1: new[] {1440}, arg2: false);
                context.SetSkill(arg1: new[] {1441}, arg2: false);
                context.SetSkill(arg1: new[] {1442}, arg2: false);
                context.SetSkill(arg1: new[] {1443}, arg2: false);
                context.SetSkill(arg1: new[] {1444}, arg2: false);
                context.SetSkill(arg1: new[] {1445}, arg2: false);
                context.SetSkill(arg1: new[] {1446}, arg2: false);
                context.SetSkill(arg1: new[] {1447}, arg2: false);
                context.SetSkill(arg1: new[] {1448}, arg2: false);
                context.SetSkill(arg1: new[] {1449}, arg2: false);
                context.SetSkill(arg1: new[] {1450}, arg2: false);
                context.SetSkill(arg1: new[] {1451}, arg2: false);
                context.SetSkill(arg1: new[] {1452}, arg2: false);
                context.SetSkill(arg1: new[] {1453}, arg2: false);
                context.SetSkill(arg1: new[] {1454}, arg2: false);
                context.SetSkill(arg1: new[] {1455}, arg2: false);
                context.SetSkill(arg1: new[] {1456}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬26(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬26 : TriggerState {
            internal State스킬26(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1445}, arg2: true);
                context.SetSkill(arg1: new[] {1446}, arg2: true);
                context.SetSkill(arg1: new[] {1447}, arg2: true);
                context.SetSkill(arg1: new[] {1448}, arg2: true);
                context.SetSkill(arg1: new[] {1449}, arg2: true);
                context.SetSkill(arg1: new[] {1450}, arg2: true);
                context.SetSkill(arg1: new[] {1451}, arg2: true);
                context.SetSkill(arg1: new[] {1452}, arg2: true);
                context.SetSkill(arg1: new[] {1453}, arg2: true);
                context.SetSkill(arg1: new[] {1454}, arg2: true);
                context.SetSkill(arg1: new[] {1455}, arg2: true);
                context.SetSkill(arg1: new[] {1456}, arg2: true);
                context.SetSkill(arg1: new[] {1457}, arg2: true);
                context.SetSkill(arg1: new[] {1458}, arg2: true);
                context.SetSkill(arg1: new[] {1459}, arg2: true);
                context.SetSkill(arg1: new[] {1460}, arg2: true);
                context.SetSkill(arg1: new[] {1461}, arg2: true);
                context.SetSkill(arg1: new[] {1462}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬27대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬27대기 : TriggerState {
            internal State스킬27대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1445}, arg2: false);
                context.SetSkill(arg1: new[] {1446}, arg2: false);
                context.SetSkill(arg1: new[] {1447}, arg2: false);
                context.SetSkill(arg1: new[] {1448}, arg2: false);
                context.SetSkill(arg1: new[] {1449}, arg2: false);
                context.SetSkill(arg1: new[] {1450}, arg2: false);
                context.SetSkill(arg1: new[] {1451}, arg2: false);
                context.SetSkill(arg1: new[] {1452}, arg2: false);
                context.SetSkill(arg1: new[] {1453}, arg2: false);
                context.SetSkill(arg1: new[] {1454}, arg2: false);
                context.SetSkill(arg1: new[] {1455}, arg2: false);
                context.SetSkill(arg1: new[] {1456}, arg2: false);
                context.SetSkill(arg1: new[] {1457}, arg2: false);
                context.SetSkill(arg1: new[] {1458}, arg2: false);
                context.SetSkill(arg1: new[] {1459}, arg2: false);
                context.SetSkill(arg1: new[] {1460}, arg2: false);
                context.SetSkill(arg1: new[] {1461}, arg2: false);
                context.SetSkill(arg1: new[] {1462}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬27(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬27 : TriggerState {
            internal State스킬27(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1451}, arg2: true);
                context.SetSkill(arg1: new[] {1452}, arg2: true);
                context.SetSkill(arg1: new[] {1453}, arg2: true);
                context.SetSkill(arg1: new[] {1454}, arg2: true);
                context.SetSkill(arg1: new[] {1455}, arg2: true);
                context.SetSkill(arg1: new[] {1456}, arg2: true);
                context.SetSkill(arg1: new[] {1457}, arg2: true);
                context.SetSkill(arg1: new[] {1458}, arg2: true);
                context.SetSkill(arg1: new[] {1459}, arg2: true);
                context.SetSkill(arg1: new[] {1460}, arg2: true);
                context.SetSkill(arg1: new[] {1461}, arg2: true);
                context.SetSkill(arg1: new[] {1462}, arg2: true);
                context.SetSkill(arg1: new[] {1463}, arg2: true);
                context.SetSkill(arg1: new[] {1464}, arg2: true);
                context.SetSkill(arg1: new[] {1465}, arg2: true);
                context.SetSkill(arg1: new[] {1466}, arg2: true);
                context.SetSkill(arg1: new[] {1467}, arg2: true);
                context.SetSkill(arg1: new[] {1468}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬28대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬28대기 : TriggerState {
            internal State스킬28대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1451}, arg2: false);
                context.SetSkill(arg1: new[] {1452}, arg2: false);
                context.SetSkill(arg1: new[] {1453}, arg2: false);
                context.SetSkill(arg1: new[] {1454}, arg2: false);
                context.SetSkill(arg1: new[] {1455}, arg2: false);
                context.SetSkill(arg1: new[] {1456}, arg2: false);
                context.SetSkill(arg1: new[] {1457}, arg2: false);
                context.SetSkill(arg1: new[] {1458}, arg2: false);
                context.SetSkill(arg1: new[] {1459}, arg2: false);
                context.SetSkill(arg1: new[] {1460}, arg2: false);
                context.SetSkill(arg1: new[] {1461}, arg2: false);
                context.SetSkill(arg1: new[] {1462}, arg2: false);
                context.SetSkill(arg1: new[] {1463}, arg2: false);
                context.SetSkill(arg1: new[] {1464}, arg2: false);
                context.SetSkill(arg1: new[] {1465}, arg2: false);
                context.SetSkill(arg1: new[] {1466}, arg2: false);
                context.SetSkill(arg1: new[] {1467}, arg2: false);
                context.SetSkill(arg1: new[] {1468}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬28(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬28 : TriggerState {
            internal State스킬28(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1457}, arg2: true);
                context.SetSkill(arg1: new[] {1458}, arg2: true);
                context.SetSkill(arg1: new[] {1459}, arg2: true);
                context.SetSkill(arg1: new[] {1460}, arg2: true);
                context.SetSkill(arg1: new[] {1461}, arg2: true);
                context.SetSkill(arg1: new[] {1462}, arg2: true);
                context.SetSkill(arg1: new[] {1463}, arg2: true);
                context.SetSkill(arg1: new[] {1464}, arg2: true);
                context.SetSkill(arg1: new[] {1465}, arg2: true);
                context.SetSkill(arg1: new[] {1466}, arg2: true);
                context.SetSkill(arg1: new[] {1467}, arg2: true);
                context.SetSkill(arg1: new[] {1468}, arg2: true);
                context.SetSkill(arg1: new[] {1469}, arg2: true);
                context.SetSkill(arg1: new[] {1470}, arg2: true);
                context.SetSkill(arg1: new[] {1471}, arg2: true);
                context.SetSkill(arg1: new[] {1472}, arg2: true);
                context.SetSkill(arg1: new[] {1473}, arg2: true);
                context.SetSkill(arg1: new[] {1474}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬29대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬29대기 : TriggerState {
            internal State스킬29대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1457}, arg2: false);
                context.SetSkill(arg1: new[] {1458}, arg2: false);
                context.SetSkill(arg1: new[] {1459}, arg2: false);
                context.SetSkill(arg1: new[] {1460}, arg2: false);
                context.SetSkill(arg1: new[] {1461}, arg2: false);
                context.SetSkill(arg1: new[] {1462}, arg2: false);
                context.SetSkill(arg1: new[] {1463}, arg2: false);
                context.SetSkill(arg1: new[] {1464}, arg2: false);
                context.SetSkill(arg1: new[] {1465}, arg2: false);
                context.SetSkill(arg1: new[] {1466}, arg2: false);
                context.SetSkill(arg1: new[] {1467}, arg2: false);
                context.SetSkill(arg1: new[] {1468}, arg2: false);
                context.SetSkill(arg1: new[] {1469}, arg2: false);
                context.SetSkill(arg1: new[] {1470}, arg2: false);
                context.SetSkill(arg1: new[] {1471}, arg2: false);
                context.SetSkill(arg1: new[] {1472}, arg2: false);
                context.SetSkill(arg1: new[] {1473}, arg2: false);
                context.SetSkill(arg1: new[] {1474}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬29(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬29 : TriggerState {
            internal State스킬29(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1463}, arg2: true);
                context.SetSkill(arg1: new[] {1464}, arg2: true);
                context.SetSkill(arg1: new[] {1465}, arg2: true);
                context.SetSkill(arg1: new[] {1466}, arg2: true);
                context.SetSkill(arg1: new[] {1467}, arg2: true);
                context.SetSkill(arg1: new[] {1468}, arg2: true);
                context.SetSkill(arg1: new[] {1469}, arg2: true);
                context.SetSkill(arg1: new[] {1470}, arg2: true);
                context.SetSkill(arg1: new[] {1471}, arg2: true);
                context.SetSkill(arg1: new[] {1472}, arg2: true);
                context.SetSkill(arg1: new[] {1473}, arg2: true);
                context.SetSkill(arg1: new[] {1474}, arg2: true);
                context.SetSkill(arg1: new[] {1475}, arg2: true);
                context.SetSkill(arg1: new[] {1476}, arg2: true);
                context.SetSkill(arg1: new[] {1477}, arg2: true);
                context.SetSkill(arg1: new[] {1478}, arg2: true);
                context.SetSkill(arg1: new[] {1479}, arg2: true);
                context.SetSkill(arg1: new[] {1480}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬30대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬30대기 : TriggerState {
            internal State스킬30대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1463}, arg2: false);
                context.SetSkill(arg1: new[] {1464}, arg2: false);
                context.SetSkill(arg1: new[] {1465}, arg2: false);
                context.SetSkill(arg1: new[] {1466}, arg2: false);
                context.SetSkill(arg1: new[] {1467}, arg2: false);
                context.SetSkill(arg1: new[] {1468}, arg2: false);
                context.SetSkill(arg1: new[] {1469}, arg2: false);
                context.SetSkill(arg1: new[] {1470}, arg2: false);
                context.SetSkill(arg1: new[] {1471}, arg2: false);
                context.SetSkill(arg1: new[] {1472}, arg2: false);
                context.SetSkill(arg1: new[] {1473}, arg2: false);
                context.SetSkill(arg1: new[] {1475}, arg2: false);
                context.SetSkill(arg1: new[] {1474}, arg2: false);
                context.SetSkill(arg1: new[] {1476}, arg2: false);
                context.SetSkill(arg1: new[] {1477}, arg2: false);
                context.SetSkill(arg1: new[] {1478}, arg2: false);
                context.SetSkill(arg1: new[] {1479}, arg2: false);
                context.SetSkill(arg1: new[] {1480}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬30(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬30 : TriggerState {
            internal State스킬30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1469}, arg2: true);
                context.SetSkill(arg1: new[] {1470}, arg2: true);
                context.SetSkill(arg1: new[] {1471}, arg2: true);
                context.SetSkill(arg1: new[] {1472}, arg2: true);
                context.SetSkill(arg1: new[] {1473}, arg2: true);
                context.SetSkill(arg1: new[] {1474}, arg2: true);
                context.SetSkill(arg1: new[] {1475}, arg2: true);
                context.SetSkill(arg1: new[] {1476}, arg2: true);
                context.SetSkill(arg1: new[] {1477}, arg2: true);
                context.SetSkill(arg1: new[] {1478}, arg2: true);
                context.SetSkill(arg1: new[] {1479}, arg2: true);
                context.SetSkill(arg1: new[] {1480}, arg2: true);
                context.SetSkill(arg1: new[] {1481}, arg2: true);
                context.SetSkill(arg1: new[] {1482}, arg2: true);
                context.SetSkill(arg1: new[] {1483}, arg2: true);
                context.SetSkill(arg1: new[] {1484}, arg2: true);
                context.SetSkill(arg1: new[] {1485}, arg2: true);
                context.SetSkill(arg1: new[] {1486}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬31대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬31대기 : TriggerState {
            internal State스킬31대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1469}, arg2: false);
                context.SetSkill(arg1: new[] {1470}, arg2: false);
                context.SetSkill(arg1: new[] {1471}, arg2: false);
                context.SetSkill(arg1: new[] {1472}, arg2: false);
                context.SetSkill(arg1: new[] {1473}, arg2: false);
                context.SetSkill(arg1: new[] {1474}, arg2: false);
                context.SetSkill(arg1: new[] {1475}, arg2: false);
                context.SetSkill(arg1: new[] {1476}, arg2: false);
                context.SetSkill(arg1: new[] {1477}, arg2: false);
                context.SetSkill(arg1: new[] {1478}, arg2: false);
                context.SetSkill(arg1: new[] {1479}, arg2: false);
                context.SetSkill(arg1: new[] {1480}, arg2: false);
                context.SetSkill(arg1: new[] {1481}, arg2: false);
                context.SetSkill(arg1: new[] {1482}, arg2: false);
                context.SetSkill(arg1: new[] {1483}, arg2: false);
                context.SetSkill(arg1: new[] {1484}, arg2: false);
                context.SetSkill(arg1: new[] {1485}, arg2: false);
                context.SetSkill(arg1: new[] {1486}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬31(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬31 : TriggerState {
            internal State스킬31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1475}, arg2: true);
                context.SetSkill(arg1: new[] {1476}, arg2: true);
                context.SetSkill(arg1: new[] {1477}, arg2: true);
                context.SetSkill(arg1: new[] {1478}, arg2: true);
                context.SetSkill(arg1: new[] {1479}, arg2: true);
                context.SetSkill(arg1: new[] {1480}, arg2: true);
                context.SetSkill(arg1: new[] {1481}, arg2: true);
                context.SetSkill(arg1: new[] {1482}, arg2: true);
                context.SetSkill(arg1: new[] {1483}, arg2: true);
                context.SetSkill(arg1: new[] {1484}, arg2: true);
                context.SetSkill(arg1: new[] {1485}, arg2: true);
                context.SetSkill(arg1: new[] {1486}, arg2: true);
                context.SetSkill(arg1: new[] {1487}, arg2: true);
                context.SetSkill(arg1: new[] {1488}, arg2: true);
                context.SetSkill(arg1: new[] {1489}, arg2: true);
                context.SetSkill(arg1: new[] {1490}, arg2: true);
                context.SetSkill(arg1: new[] {1491}, arg2: true);
                context.SetSkill(arg1: new[] {1492}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬32대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬32대기 : TriggerState {
            internal State스킬32대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1475}, arg2: false);
                context.SetSkill(arg1: new[] {1476}, arg2: false);
                context.SetSkill(arg1: new[] {1477}, arg2: false);
                context.SetSkill(arg1: new[] {1478}, arg2: false);
                context.SetSkill(arg1: new[] {1479}, arg2: false);
                context.SetSkill(arg1: new[] {1480}, arg2: false);
                context.SetSkill(arg1: new[] {1481}, arg2: false);
                context.SetSkill(arg1: new[] {1482}, arg2: false);
                context.SetSkill(arg1: new[] {1483}, arg2: false);
                context.SetSkill(arg1: new[] {1484}, arg2: false);
                context.SetSkill(arg1: new[] {1485}, arg2: false);
                context.SetSkill(arg1: new[] {1486}, arg2: false);
                context.SetSkill(arg1: new[] {1487}, arg2: false);
                context.SetSkill(arg1: new[] {1488}, arg2: false);
                context.SetSkill(arg1: new[] {1489}, arg2: false);
                context.SetSkill(arg1: new[] {1490}, arg2: false);
                context.SetSkill(arg1: new[] {1491}, arg2: false);
                context.SetSkill(arg1: new[] {1492}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬32(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬32 : TriggerState {
            internal State스킬32(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1481}, arg2: true);
                context.SetSkill(arg1: new[] {1482}, arg2: true);
                context.SetSkill(arg1: new[] {1483}, arg2: true);
                context.SetSkill(arg1: new[] {1484}, arg2: true);
                context.SetSkill(arg1: new[] {1485}, arg2: true);
                context.SetSkill(arg1: new[] {1486}, arg2: true);
                context.SetSkill(arg1: new[] {1487}, arg2: true);
                context.SetSkill(arg1: new[] {1488}, arg2: true);
                context.SetSkill(arg1: new[] {1489}, arg2: true);
                context.SetSkill(arg1: new[] {1490}, arg2: true);
                context.SetSkill(arg1: new[] {1491}, arg2: true);
                context.SetSkill(arg1: new[] {1492}, arg2: true);
                context.SetSkill(arg1: new[] {1493}, arg2: true);
                context.SetSkill(arg1: new[] {1494}, arg2: true);
                context.SetSkill(arg1: new[] {1495}, arg2: true);
                context.SetSkill(arg1: new[] {1496}, arg2: true);
                context.SetSkill(arg1: new[] {1497}, arg2: true);
                context.SetSkill(arg1: new[] {1498}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬33대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬33대기 : TriggerState {
            internal State스킬33대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1481}, arg2: false);
                context.SetSkill(arg1: new[] {1482}, arg2: false);
                context.SetSkill(arg1: new[] {1483}, arg2: false);
                context.SetSkill(arg1: new[] {1484}, arg2: false);
                context.SetSkill(arg1: new[] {1485}, arg2: false);
                context.SetSkill(arg1: new[] {1486}, arg2: false);
                context.SetSkill(arg1: new[] {1487}, arg2: false);
                context.SetSkill(arg1: new[] {1488}, arg2: false);
                context.SetSkill(arg1: new[] {1489}, arg2: false);
                context.SetSkill(arg1: new[] {1490}, arg2: false);
                context.SetSkill(arg1: new[] {1491}, arg2: false);
                context.SetSkill(arg1: new[] {1492}, arg2: false);
                context.SetSkill(arg1: new[] {1493}, arg2: false);
                context.SetSkill(arg1: new[] {1494}, arg2: false);
                context.SetSkill(arg1: new[] {1495}, arg2: false);
                context.SetSkill(arg1: new[] {1496}, arg2: false);
                context.SetSkill(arg1: new[] {1497}, arg2: false);
                context.SetSkill(arg1: new[] {1498}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬33(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬33 : TriggerState {
            internal State스킬33(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1487}, arg2: true);
                context.SetSkill(arg1: new[] {1488}, arg2: true);
                context.SetSkill(arg1: new[] {1489}, arg2: true);
                context.SetSkill(arg1: new[] {1490}, arg2: true);
                context.SetSkill(arg1: new[] {1491}, arg2: true);
                context.SetSkill(arg1: new[] {1492}, arg2: true);
                context.SetSkill(arg1: new[] {1493}, arg2: true);
                context.SetSkill(arg1: new[] {1494}, arg2: true);
                context.SetSkill(arg1: new[] {1495}, arg2: true);
                context.SetSkill(arg1: new[] {1496}, arg2: true);
                context.SetSkill(arg1: new[] {1497}, arg2: true);
                context.SetSkill(arg1: new[] {1498}, arg2: true);
                context.SetSkill(arg1: new[] {1499}, arg2: true);
                context.SetSkill(arg1: new[] {1500}, arg2: true);
                context.SetSkill(arg1: new[] {1501}, arg2: true);
                context.SetSkill(arg1: new[] {1502}, arg2: true);
                context.SetSkill(arg1: new[] {1503}, arg2: true);
                context.SetSkill(arg1: new[] {1504}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬34대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬34대기 : TriggerState {
            internal State스킬34대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1487}, arg2: false);
                context.SetSkill(arg1: new[] {1488}, arg2: false);
                context.SetSkill(arg1: new[] {1489}, arg2: false);
                context.SetSkill(arg1: new[] {1490}, arg2: false);
                context.SetSkill(arg1: new[] {1491}, arg2: false);
                context.SetSkill(arg1: new[] {1492}, arg2: false);
                context.SetSkill(arg1: new[] {1493}, arg2: false);
                context.SetSkill(arg1: new[] {1494}, arg2: false);
                context.SetSkill(arg1: new[] {1495}, arg2: false);
                context.SetSkill(arg1: new[] {1496}, arg2: false);
                context.SetSkill(arg1: new[] {1497}, arg2: false);
                context.SetSkill(arg1: new[] {1498}, arg2: false);
                context.SetSkill(arg1: new[] {1499}, arg2: false);
                context.SetSkill(arg1: new[] {1500}, arg2: false);
                context.SetSkill(arg1: new[] {1501}, arg2: false);
                context.SetSkill(arg1: new[] {1502}, arg2: false);
                context.SetSkill(arg1: new[] {1503}, arg2: false);
                context.SetSkill(arg1: new[] {1504}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}