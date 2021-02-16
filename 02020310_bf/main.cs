namespace Maple2.Trigger._02020310_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 10000, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 10001, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 10002, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 10003, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 10004, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 10005, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 10006, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 10007, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 10008, arg2: false, arg3: false, arg4: false);
                context.EnableSpawnPointPc(spawnPointId: 101, isEnable: true);
                context.EnableSpawnPointPc(spawnPointId: 102, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 103, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 104, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 105, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 106, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 107, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 108, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 109, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 110, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 111, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 112, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 113, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 114, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 115, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 116, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 117, isEnable: false);
                context.SetInteractObject(arg1: new[] {12000301, 12000302, 12000303, 12000304, 12000305, 12000306, 12000307, 12000308, 12000309, 12000310, 12000311, 12000312, 12000313, 12000314, 12000315, 12000316, 12000317, 12000318, 12000319, 12000320, 12000321}, arg2: 0);
                context.SetInteractObject(arg1: new[] {12000404, 12000405}, arg2: 1);
                context.SetMesh(arg1: new[] {8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008, 8009, 8010, 8011, 8012, 8013, 8014, 8015, 8016, 8017, 8018, 8019, 8020, 8021, 8022, 8023, 8024, 8025, 8026, 8027, 8028, 8029, 8030, 8031, 8032, 8033, 8034, 8035, 8036, 8037, 8038, 8039, 8040, 8041, 8042, 8043, 8044, 8045, 8046, 8047, 8048, 8049, 8050, 8051, 8052, 8053, 8054, 8055, 8056, 8057, 8058, 8059, 8060, 8061, 8062, 8063, 8064, 8065, 8066, 8067, 8068, 8069, 8070, 8071, 8072, 8073, 8074, 8075, 8076, 8077, 8078, 8079, 8080, 8081, 8082, 8083, 8084, 8085, 8086, 8087, 8088, 8089, 8090, 8091, 8092, 8093, 8094, 8095, 8096, 8097, 8098, 8099, 8100, 8101, 8102, 8103, 8104, 8105, 8106, 8107, 8108, 8109, 8110, 8111, 8112, 8113, 8114, 8115, 8116, 8117, 8118, 8119, 8120, 8121, 8122, 8123, 8124, 8125, 8126, 8127, 8128, 8129, 8130, 8131, 8132, 8133, 8134, 8135, 8136, 8137, 8138, 8139, 8140, 8141, 8142, 8143, 8144, 8145, 8146, 8147, 8148, 8149, 8150, 8151, 8152, 8153, 8154, 8155, 8156, 8157, 8158, 8159, 8160, 8161, 8162, 8163, 8164, 8165, 8166, 8167, 8168, 8169, 8170, 8171, 8172, 8173, 8174, 8175, 8176, 8177, 8178, 8179, 8180, 8181, 8182, 8183, 8184, 8185, 8186, 8187, 8188, 8189, 8190, 8191, 8192, 8193, 8194, 8195, 8196, 8197, 8198, 88001, 88002, 88003, 88004, 88005, 88006, 88007, 88008, 88009, 88010, 88011, 88012, 88013, 88014, 88015, 88016, 88017, 88018, 88019, 88020, 88021, 88022, 88023, 88024, 88025, 88026, 88027, 88028, 88029, 88030, 88031, 88032, 88033, 88034, 88035, 88036, 88037, 88038, 88039, 88040, 88041, 88042, 88043, 88044, 88045, 88046, 88047, 88048, 89001, 89002, 89003, 89004, 89005, 89006, 89007, 89008, 89009, 89010, 89011, 89012, 89013, 89014, 89015, 89016, 89017, 89018, 89019, 89020, 89021, 89022, 89023, 89024, 89025, 89026, 89027, 89028, 89029, 89030, 89031, 89032, 89033, 89034, 89035, 89036, 89037, 89038, 89039, 89040, 89041, 89042, 89043, 89044, 89045, 89046, 89047, 89048}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {1100001, 1100002, 1100003, 1100004, 1100005, 1100006, 1100007, 1100008, 1100009, 1100010, 1100021, 1100022, 1100023, 1100024, 1100025, 1100026, 1100027, 1100028, 1100029, 1100030, 1100031, 1100032, 1100033, 1100034, 1100035, 1100036, 1100037, 1100038, 1100039, 1100040, 1100101, 1100102, 1100103, 1100104, 1100105, 1100106, 1100107, 1100108, 1100109, 1100110, 1100201, 1100202, 1100203, 1100204, 1100205, 1100206, 1100207, 1100208, 1100209, 1100210, 1100301, 1100302, 1100303, 1100304, 1100305, 1100306, 1100307, 1100308, 1100309, 1100310, 1101001, 1101002, 1101003, 1101004, 1101005, 1101006, 1101007, 1101008, 1101009, 1101010, 1102001, 1102002, 1102003, 1102004, 1102005, 1102006, 1102007, 1102008, 1102009, 1102010, 1103001, 1103002, 1103003, 1103004, 1103005, 1103006, 1103007, 1103008, 1103009, 1103010, 1104001, 1104002, 1104003, 1104004, 1104005, 1104006, 1104007, 1104008, 1104009, 1104010, 1105001, 1105002, 1105003, 1105004, 1105005, 1105006, 1105007, 1105008, 1105009, 1105010, 1106001, 1106002, 1106003, 1106004, 1106005, 1106006, 1106007, 1106008, 1106009, 1106010, 1110001, 1110002, 1110003, 1110004, 1110005, 1110006, 1110007, 1110008, 1110009, 1110010, 1120001, 1120002, 1120003, 1120004, 1120005, 1120006, 1120007, 1120008, 1120009, 1120010, 1130001, 1130002, 1130003, 1130004, 1130005, 1130006, 1130007, 1130008, 1130009, 1130010, 1140001, 1140002, 1140003, 1140004, 1140005, 1140006, 1140007, 1140008, 1140009, 1140010, 1150001, 1150002, 1150003, 1150004, 1150005, 1150006, 1150007, 1150008, 1150009, 1150010, 1160001, 1160002, 1160003, 1160004, 1160005, 1160006, 1160007, 1160008, 1160009, 1160010, 1210001, 1210002, 1210003, 1210004, 1210005, 1210006, 1210007, 1210008, 1210009, 1210010, 1310001, 1310002, 1310003, 1310004, 1310005, 1310006, 1310007, 1310008, 1310009, 1310010, 1410001, 1410002, 1410003, 1410004, 1410005, 1410006, 1410007, 1410008, 1410009, 1410010}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(arg1: new[] {1100001, 1100002, 1100003, 1100004, 1100005, 1100006, 1100007, 1100008, 1100009, 1100010, 1100021, 1100022, 1100023, 1100024, 1100025, 1100026, 1100027, 1100028, 1100029, 1100030, 1100031, 1100032, 1100033, 1100034, 1100035, 1100036, 1100037, 1100038, 1100039, 1100040, 1100101, 1100102, 1100103, 1100104, 1100105, 1100106, 1100107, 1100108, 1100109, 1100110, 1100201, 1100202, 1100203, 1100204, 1100205, 1100206, 1100207, 1100208, 1100209, 1100210, 1100301, 1100302, 1100303, 1100304, 1100305, 1100306, 1100307, 1100308, 1100309, 1100310, 1101001, 1101002, 1101003, 1101004, 1101005, 1101006, 1101007, 1101008, 1101009, 1101010, 1102001, 1102002, 1102003, 1102004, 1102005, 1102006, 1102007, 1102008, 1102009, 1102010, 1103001, 1103002, 1103003, 1103004, 1103005, 1103006, 1103007, 1103008, 1103009, 1103010, 1104001, 1104002, 1104003, 1104004, 1104005, 1104006, 1104007, 1104008, 1104009, 1104010, 1105001, 1105002, 1105003, 1105004, 1105005, 1105006, 1105007, 1105008, 1105009, 1105010, 1106001, 1106002, 1106003, 1106004, 1106005, 1106006, 1106007, 1106008, 1106009, 1106010, 1110001, 1110002, 1110003, 1110004, 1110005, 1110006, 1110007, 1110008, 1110009, 1110010, 1120001, 1120002, 1120003, 1120004, 1120005, 1120006, 1120007, 1120008, 1120009, 1120010, 1130001, 1130002, 1130003, 1130004, 1130005, 1130006, 1130007, 1130008, 1130009, 1130010, 1140001, 1140002, 1140003, 1140004, 1140005, 1140006, 1140007, 1140008, 1140009, 1140010, 1150001, 1150002, 1150003, 1150004, 1150006, 1150006, 1150007, 1150008, 1150009, 1150010, 1160001, 1160002, 1160003, 1160004, 1160005, 1160006, 1160007, 1160008, 1160009, 1160010, 1210001, 1210002, 1210003, 1210004, 1210005, 1210006, 1210007, 1210008, 1210009, 1210010, 1310001, 1310002, 1310003, 1310004, 1310005, 1310006, 1310007, 1310008, 1310009, 1310010, 1410001, 1410002, 1410003, 1410004, 1410005, 1410006, 1410007, 1410008, 1410009, 1410010}, arg2: true, arg3: 0, arg4: 0);
                context.SetVisibleBreakableObject(arg1: new[] {1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016, 1017, 1018, 1019, 1020, 1021, 1022}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {900})) {
                    return new StateCamera시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera시작 : TriggerState {
            internal StateCamera시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateCamera종료(context), arg2: "exit");
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CameraSelectPath(arg1: new[] {100001, 100002, 100003, 100004, 100005}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State마를레네대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마를레네대사 : TriggerState {
            internal State마를레네대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11004582, msg: "$02020310_BF__MAIN__0$", align: "left", illustId: "Eone_serious", duration: 6000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 9500)) {
                    return new StateCamera종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera종료 : TriggerState {
            internal StateCamera종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.CameraReset(interpolationTime: 0f);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }

            public override TriggerState Execute() {
                context.SideNpcTalk(type: "talk", npcId: 11004582, illust: "Eone_normal", script: "$02020310_BF__MAIN__1$", duration: 6000);
                    context.SetSceneSkip();
                    return new StateStartDelay(context);
            }

            public override void OnExit() { }
        }

        private class StateStartDelay : TriggerState {
            internal StateStartDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.CreateMonster(arg1: new[] {1101, 1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016, 1017, 1018, 1019, 1020}, arg2: false);
                    return new StateLineStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLineStart : TriggerState {
            internal StateLineStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1101, 1001, 1002, 1005, 1006, 1009, 1010, 1011, 1012, 1015, 1016, 1017, 1018, 1019, 1020})) {
                    context.SideNpcTalk(type: "talk", npcId: 11004582, illust: "Eone_normal", script: "$02020310_BF__MAIN__2$", duration: 8000);
                    context.EnableSpawnPointPc(spawnPointId: 101, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 102, isEnable: true);
                    context.SetInteractObject(arg1: new[] {12000301, 12000302, 12000303}, arg2: 1);
                    context.CreateMonster(arg1: new[] {1104, 1105, 1106, 1150, 1151, 1152, 1153, 1154, 1155, 1156, 1157, 1158, 1159, 1160, 1161, 1162, 1163, 1164, 1165, 1166, 1167, 1168, 1169, 1170, 1171, 1172}, arg2: false);
                    return new StateCableOn_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOn_01 : TriggerState {
            internal StateCableOn_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000301}, arg2: 0)) {
                    context.SetInteractObject(arg1: new[] {12000302, 12000303}, arg2: 0);
                    context.SetMesh(arg1: new[] {1100001, 1100002, 1100003, 1100004, 1100005, 1100006, 1100007, 1100008, 1100009, 1100010}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateCableDelay_01_1(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000302}, arg2: 0)) {
                    context.SetInteractObject(arg1: new[] {12000301, 12000303}, arg2: 0);
                    context.SetMesh(arg1: new[] {1100031, 1100032, 1100033, 1100034, 1100035, 1100036, 1100037, 1100038, 1100039, 1100040}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateCableDelay_01_2(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000303}, arg2: 0)) {
                    context.SetInteractObject(arg1: new[] {12000301, 12000302}, arg2: 0);
                    context.SetMesh(arg1: new[] {1100021, 1100022, 1100023, 1100024, 1100025, 1100026, 1100027, 1100028, 1100029, 1100030}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateCableDelay_01_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_01_1 : TriggerState {
            internal StateCableDelay_01_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetEventUI(arg1: 1, arg2: "$02020310_BF__MAIN__3$", arg3: 3000);
                    return new StateCableDelay_02_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_01_2 : TriggerState {
            internal StateCableDelay_01_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetEventUI(arg1: 1, arg2: "$02020310_BF__MAIN__4$", arg3: 3000);
                    return new StateCableDelay_02_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_01_3 : TriggerState {
            internal StateCableDelay_01_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetEventUI(arg1: 1, arg2: "$02020310_BF__MAIN__5$", arg3: 3000);
                    return new StateCableDelay_02_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_02_1 : TriggerState {
            internal StateCableDelay_02_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetEventUI(arg1: 1, arg2: "$02020310_BF__MAIN__6$", arg3: 1000);
                    return new StateCableDelay_03_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_02_2 : TriggerState {
            internal StateCableDelay_02_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetEventUI(arg1: 1, arg2: "$02020310_BF__MAIN__7$", arg3: 1000);
                    return new StateCableDelay_03_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_02_3 : TriggerState {
            internal StateCableDelay_02_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetEventUI(arg1: 1, arg2: "$02020310_BF__MAIN__8$", arg3: 1000);
                    return new StateCableDelay_03_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_03_1 : TriggerState {
            internal StateCableDelay_03_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, arg2: "$02020310_BF__MAIN__9$", arg3: 1000);
                    return new StateCableDelay_04_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_03_2 : TriggerState {
            internal StateCableDelay_03_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, arg2: "$02020310_BF__MAIN__10$", arg3: 1000);
                    return new StateCableDelay_04_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_03_3 : TriggerState {
            internal StateCableDelay_03_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, arg2: "$02020310_BF__MAIN__11$", arg3: 1000);
                    return new StateCableDelay_04_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_04_1 : TriggerState {
            internal StateCableDelay_04_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, arg2: "$02020310_BF__MAIN__12$", arg3: 1000);
                    return new StateCableDelay_05_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_04_2 : TriggerState {
            internal StateCableDelay_04_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, arg2: "$02020310_BF__MAIN__13$", arg3: 1000);
                    return new StateCableDelay_05_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_04_3 : TriggerState {
            internal StateCableDelay_04_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, arg2: "$02020310_BF__MAIN__14$", arg3: 1000);
                    return new StateCableDelay_05_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_05_1 : TriggerState {
            internal StateCableDelay_05_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(arg1: new[] {1001}, arg2: true);
                    context.SetEventUI(arg1: 1, arg2: "$02020310_BF__MAIN__15$", arg3: 5000);
                    return new StateCableOff_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_05_2 : TriggerState {
            internal StateCableDelay_05_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(arg1: new[] {1002}, arg2: true);
                    context.SetEventUI(arg1: 1, arg2: "$02020310_BF__MAIN__16$", arg3: 5000);
                    return new StateCableOff_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_05_3 : TriggerState {
            internal StateCableDelay_05_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(arg1: new[] {1003}, arg2: true);
                    context.SetEventUI(arg1: 1, arg2: "$02020310_BF__MAIN__17$", arg3: 5000);
                    return new StateCableOff_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOff_01 : TriggerState {
            internal StateCableOff_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerId: 900002, key: "Block", value: 1);
                    return new StateEnd_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOff_02 : TriggerState {
            internal StateCableOff_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerId: 900002, key: "Block", value: 2);
                    return new StateEnd_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOff_03 : TriggerState {
            internal StateCableOff_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerId: 900002, key: "Block", value: 3);
                    return new StateEnd_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd_01 : TriggerState {
            internal StateEnd_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) { }

                return null;
            }

            public override void OnExit() { }
        }
    }
}