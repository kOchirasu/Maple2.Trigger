namespace Maple2.Trigger._99999909 {
    public static class _event_02 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000030}, arg2: 0)) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {1001}, arg2: false, arg3: 0, arg4: 200, arg5: 15f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {703})) {
                    return new StateScene_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_01 : TriggerState {
            internal StateScene_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CameraSelectPath(arg1: new[] {8001, 8002}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateScene_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_02 : TriggerState {
            internal StateScene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(arg1: "scene_06_ready");
                context.SetConversation(arg1: 2, arg2: 11001956, arg3: "$99999909__EVENT_02__0$", arg4: 5);
                context.MoveNpc(arg1: 199, arg2: "MS2PatrolData_2001");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateScene_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_03 : TriggerState {
            internal StateScene_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(arg1: "scene_06_ready");
                context.SetConversation(arg1: 2, arg2: 11001956, arg3: "$99999909__EVENT_02__1$", arg4: 5);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateScene_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_04 : TriggerState {
            internal StateScene_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(arg1: "scene_06_ready");
                context.CameraSelectPath(arg1: new[] {8003, 8004}, arg2: false);
                context.SetMesh(arg1: new[] {1002}, arg2: true, arg3: 0, arg4: 200, arg5: 25f);
                context.SetMesh(arg1: new[] {1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108, 1109, 1110, 1111, 1112, 1113, 1114, 1115, 1116, 1117, 1118, 1119, 1120, 1121, 1122, 1123, 1124, 1125, 1126, 1127, 1128, 1129, 1130, 1131, 1132, 1133, 1134, 1135, 1136, 1137, 1138, 1139, 1140, 1141, 1142, 1143, 1144, 1145, 1146, 1147, 1148, 1149, 1150, 1151, 1152, 1153, 1154, 1155, 1156, 1157, 1158, 1159, 1160, 1161, 1162, 1163, 1164, 1165, 1166, 1167, 1168, 1169, 1170, 1171, 1172, 1173, 1174, 1175, 1176, 1177, 1178, 1179, 1180, 1181, 1182, 1183, 1184, 1185, 1186, 1187, 1188, 1189, 1190, 1191, 1192, 1193, 1194, 1195, 1196, 1197, 1198, 1199}, arg2: true, arg3: 0, arg4: 200, arg5: 25f);
                context.SetConversation(arg1: 2, arg2: 11001956, arg3: "$99999909__EVENT_02__2$", arg4: 5);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateScene_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_05 : TriggerState {
            internal StateScene_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(arg1: "scene_06_ready");
                context.CameraSelectPath(arg1: new[] {8005}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 199, arg2: "Bore_B");
                context.SetConversation(arg1: 2, arg2: 11001956, arg3: "$99999909__EVENT_02__3$", arg4: 5);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateScene_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_06 : TriggerState {
            internal StateScene_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {199});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateScene_06_ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_06_ready : TriggerState {
            internal StateScene_06_ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetMesh(arg1: new[] {1002}, arg2: true, arg3: 0, arg4: 200, arg5: 25f);
                context.SetMesh(arg1: new[] {1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108, 1109, 1110, 1111, 1112, 1113, 1114, 1115, 1116, 1117, 1118, 1119, 1120, 1121, 1122, 1123, 1124, 1125, 1126, 1127, 1128, 1129, 1130, 1131, 1132, 1133, 1134, 1135, 1136, 1137, 1138, 1139, 1140, 1141, 1142, 1143, 1144, 1145, 1146, 1147, 1148, 1149, 1150, 1151, 1152, 1153, 1154, 1155, 1156, 1157, 1158, 1159, 1160, 1161, 1162, 1163, 1164, 1165, 1166, 1167, 1168, 1169, 1170, 1171, 1172, 1173, 1174, 1175, 1176, 1177, 1178, 1179, 1180, 1181, 1182, 1183, 1184, 1185, 1186, 1187, 1188, 1189, 1190, 1191, 1192, 1193, 1194, 1195, 1196, 1197, 1198, 1199}, arg2: true, arg3: 0, arg4: 200, arg5: 25f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateScene_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_07 : TriggerState {
            internal StateScene_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {199});
                context.CreateMonster(arg1: new[] {105, 106, 107, 108, 109, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 150, 151, 152, 153, 154, 155, 156}, arg2: false);
                context.CameraReset(interpolationTime: 0.0f);
                context.SetEventUI(arg1: 1, arg2: "$99999909__EVENT_02__4$", arg3: 3000);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}