using System;

namespace Maple2.Trigger._02000471_bf {
    public static class _event_02 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10002018}, arg2: 0)) {
                    context.State = new StateReady(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {1001}, arg2: false, arg3: 0, arg4: 200, arg5: 15f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "703")) {
                    context.State = new Statescene_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_01 : TriggerState {
            internal Statescene_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.DestroyMonster(arg1: new int[] {101, 102, 103, 104});
                context.CameraSelectPath(arg1: new int[] {8001, 8002}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new Statescene_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_02 : TriggerState {
            internal Statescene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "scene_06_ready", arg2: "exit");
                context.SetConversation(arg1: 2, arg2: 11001956, arg3: "$02000471_BF__EVENT_02__0$", arg4: 5);
                context.MoveNpc(arg1: 199, arg2: "MS2PatrolData_2001");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statescene_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_03 : TriggerState {
            internal Statescene_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001956, arg3: "$02000471_BF__EVENT_02__1$", arg4: 5);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statescene_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_04 : TriggerState {
            internal Statescene_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8003, 8004}, arg2: false);
                context.SetMesh(arg1: new int[] {1002}, arg2: true, arg3: 0, arg4: 200, arg5: 35f);
                context.SetMesh(
                    arg1: new int[] {
                        1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108, 1109, 1110, 1111, 1112, 1113, 1114, 1115, 1116,
                        1117, 1118, 1119, 1120, 1121, 1122, 1123, 1124, 1125, 1126, 1127, 1128, 1129, 1130, 1131, 1132,
                        1133, 1134, 1135, 1136, 1137, 1138, 1139, 1140, 1141, 1142, 1143, 1144, 1145, 1146, 1147, 1148,
                        1149, 1150, 1151, 1152, 1153, 1154, 1155, 1156, 1157, 1158, 1159, 1160, 1161, 1162, 1163, 1164,
                        1165, 1166, 1167, 1168, 1169, 1170, 1171, 1172, 1173, 1174, 1175, 1176, 1177, 1178, 1179, 1180,
                        1181, 1182, 1183, 1184, 1185, 1186, 1187, 1188, 1189, 1190, 1191, 1192, 1193, 1194, 1195, 1196,
                        1197, 1198, 1199
                    }, arg2: true, arg3: 0, arg4: 200, arg5: 35f);
                context.SetConversation(arg1: 2, arg2: 11001956, arg3: "$02000471_BF__EVENT_02__2$", arg4: 5);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new Statescene_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_05 : TriggerState {
            internal Statescene_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8005}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 199, arg2: "Bore_B");
                context.SetConversation(arg1: 2, arg2: 11001956, arg3: "$02000471_BF__EVENT_02__3$", arg4: 5);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statescene_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_06 : TriggerState {
            internal Statescene_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {199});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statescene_06_ready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_06_ready : TriggerState {
            internal Statescene_06_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetInteractObject(arg1: new int[] {10002019}, arg2: 1);
                context.SetInteractObject(arg1: new int[] {10002020}, arg2: 1);
                context.SetInteractObject(arg1: new int[] {10002021}, arg2: 1);
                context.SetInteractObject(arg1: new int[] {12000034}, arg2: 1);
                context.SetInteractObject(arg1: new int[] {10002023}, arg2: 1);
                context.SetInteractObject(arg1: new int[] {10002024}, arg2: 1);
                context.DestroyMonster(arg1: new int[] {199});
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetMesh(arg1: new int[] {1002}, arg2: true, arg3: 0, arg4: 200, arg5: 35f);
                context.SetMesh(
                    arg1: new int[] {
                        1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108, 1109, 1110, 1111, 1112, 1113, 1114, 1115, 1116,
                        1117, 1118, 1119, 1120, 1121, 1122, 1123, 1124, 1125, 1126, 1127, 1128, 1129, 1130, 1131, 1132,
                        1133, 1134, 1135, 1136, 1137, 1138, 1139, 1140, 1141, 1142, 1143, 1144, 1145, 1146, 1147, 1148,
                        1149, 1150, 1151, 1152, 1153, 1154, 1155, 1156, 1157, 1158, 1159, 1160, 1161, 1162, 1163, 1164,
                        1165, 1166, 1167, 1168, 1169, 1170, 1171, 1172, 1173, 1174, 1175, 1176, 1177, 1178, 1179, 1180,
                        1181, 1182, 1183, 1184, 1185, 1186, 1187, 1188, 1189, 1190, 1191, 1192, 1193, 1194, 1195, 1196,
                        1197, 1198, 1199
                    }, arg2: true, arg3: 0, arg4: 200, arg5: 35f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statescene_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_07 : TriggerState {
            internal Statescene_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 2040314, key: "TimerStart", value: 1);
                context.DestroyMonster(arg1: new int[] {199});
                context.CreateMonster(
                    arg1: new int[] {105, 106, 107, 108, 109, 111, 112, 113, 114, 115, 116, 117, 118, 119},
                    arg2: false);
                context.CreateMonster(arg1: new int[] {120, 121, 122, 123, 124, 125, 126, 127, 128, 129}, arg2: false);
                context.CreateMonster(arg1: new int[] {130, 131, 132, 133, 134, 135, 136}, arg2: false);
                context.CreateMonster(arg1: new int[] {150, 151, 152, 153, 154, 155, 156}, arg2: false);
                context.CameraReset(interpolationTime: 0.0f);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statescene_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_08 : TriggerState {
            internal Statescene_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000471_BF__EVENT_02__9$", arg3: new int[] {5000});
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {106, 105, 116, 115})) {
                    context.State = new Statescene_09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_09 : TriggerState {
            internal Statescene_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 720, arg2: "trigger", arg3: "Hauntedmansion");
                context.CreateMonster(arg1: new int[] {181, 182, 183, 184}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statescene_10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_10 : TriggerState {
            internal Statescene_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 181, arg3: "$02000471_BF__EVENT_02__5$", arg4: 3, arg5: 2);
                context.SetConversation(arg1: 1, arg2: 182, arg3: "$02000471_BF__EVENT_02__6$", arg4: 3, arg5: 4);
                context.SetConversation(arg1: 1, arg2: 183, arg3: "$02000471_BF__EVENT_02__7$", arg4: 3, arg5: 8);
                context.SetConversation(arg1: 1, arg2: 184, arg3: "$02000471_BF__EVENT_02__8$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    context.State = new Statescene_10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_11 : TriggerState {
            internal Statescene_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {181, 182, 183, 184});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}