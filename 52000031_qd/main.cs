namespace Maple2.Trigger._52000031_qd {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3100, 3200}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{601, 602, 603}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{101}, jobCode: 90)) {
                    return new StateStartCinematic(context);
                }

                if (context.UserDetected(boxIds: new []{101}, jobCode: 10)) {
                    return new StateStartCinematic10(context);
                }

                if (context.UserDetected(boxIds: new []{101}, jobCode: 01)) {
                    return new StateStartCinematic10(context);
                }

                if (context.UserDetected(boxIds: new []{101}, jobCode: 20)) {
                    return new StateStartCinematic20(context);
                }

                if (context.UserDetected(boxIds: new []{101}, jobCode: 30)) {
                    return new StateStartCinematic30(context);
                }

                if (context.UserDetected(boxIds: new []{101}, jobCode: 40)) {
                    return new StateStartCinematic40(context);
                }

                if (context.UserDetected(boxIds: new []{101}, jobCode: 50)) {
                    return new StateStartCinematic50(context);
                }

                if (context.UserDetected(boxIds: new []{101}, jobCode: 60)) {
                    return new StateStartCinematic60(context);
                }

                if (context.UserDetected(boxIds: new []{101}, jobCode: 70)) {
                    return new StateStartCinematic50(context);
                }

                if (context.UserDetected(boxIds: new []{101}, jobCode: 80)) {
                    return new StateStartCinematic60(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 301, enable: true);
                context.CreateMonster(spawnIds: new []{1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 2001, 2002}, arg2: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetConversation(type: 2, spawnId: 11001230, script: "$52000031_QD__MAIN__0$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateBattleStart(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class StateStartCinematic10 : TriggerState {
            internal StateStartCinematic10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 301, enable: true);
                context.CreateMonster(spawnIds: new []{1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 2001, 2002}, arg2: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetConversation(type: 2, spawnId: 11000076, script: "$52000031_QD__MAIN__1$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateBattleStart(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class StateStartCinematic20 : TriggerState {
            internal StateStartCinematic20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 301, enable: true);
                context.CreateMonster(spawnIds: new []{1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 2001, 2002}, arg2: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetConversation(type: 2, spawnId: 11001581, script: "$52000031_QD__MAIN__2$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateBattleStart(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class StateStartCinematic30 : TriggerState {
            internal StateStartCinematic30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 301, enable: true);
                context.CreateMonster(spawnIds: new []{1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 2001, 2002}, arg2: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetEffect(triggerIds: new []{602}, visible: true);
                context.SetConversation(type: 2, spawnId: 11000032, script: "$52000031_QD__MAIN__3$", arg4: 5, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateBattleStart(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class StateStartCinematic40 : TriggerState {
            internal StateStartCinematic40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 301, enable: true);
                context.CreateMonster(spawnIds: new []{1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 2001, 2002}, arg2: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetConversation(type: 2, spawnId: 11001578, script: "$52000031_QD__MAIN__4$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateBattleStart(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class StateStartCinematic50 : TriggerState {
            internal StateStartCinematic50(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 301, enable: true);
                context.CreateMonster(spawnIds: new []{1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 2001, 2002}, arg2: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetConversation(type: 2, spawnId: 11000015, script: "$52000031_QD__MAIN__5$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateBattleStart(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class StateStartCinematic60 : TriggerState {
            internal StateStartCinematic60(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 301, enable: true);
                context.CreateMonster(spawnIds: new []{1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 2001, 2002}, arg2: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetConversation(type: 2, spawnId: 11001583, script: "$52000031_QD__MAIN__6$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateBattleStart(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class StateStartCinematic70 : TriggerState {
            internal StateStartCinematic70(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 301, enable: true);
                context.CreateMonster(spawnIds: new []{1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 2001, 2002}, arg2: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetConversation(type: 2, spawnId: 11001586, script: "$52000031_QD__MAIN__7$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateBattleStart(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class StateStartCinematic80 : TriggerState {
            internal StateStartCinematic80(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 301, enable: true);
                context.CreateMonster(spawnIds: new []{1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 2001, 2002}, arg2: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetConversation(type: 2, spawnId: 11001584, script: "$52000031_QD__MAIN__8$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateBattleStart(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class StateBattleStart : TriggerState {
            internal StateBattleStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 301, enable: false);
                context.CameraSelect(triggerId: 302, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2001})) {
                    return new State2차전투(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(spawnIds: new []{2002});
            }
        }

        private class State2차전투 : TriggerState {
            internal State2차전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2003, 2004}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2003})) {
                    return new State렌듀비앙Script02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(spawnIds: new []{2004});
                context.CameraSelect(triggerId: 302, enable: false);
            }
        }

        private class State렌듀비앙Script02 : TriggerState {
            internal State렌듀비앙Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3100, 3200}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115}, visible: true, arg3: 0, arg4: 100, arg5: 1f);
                context.SetMesh(triggerIds: new []{3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212}, visible: true, arg3: 0, arg4: 100, arg5: 1f);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetConversation(type: 2, spawnId: 11001230, script: "$52000031_QD__MAIN__9$", arg4: 3, arg5: 0);
                context.SetConversation(type: 2, spawnId: 11001244, script: "$52000031_QD__MAIN__10$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State유페리아Script_기타음성1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유페리아Script_기타음성1 : TriggerState {
            internal State유페리아Script_기타음성1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{603}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001564, script: "$52000031_QD__MAIN__11$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new StateIshura외침01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIshura외침01 : TriggerState {
            internal StateIshura외침01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{601}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001244, script: "$52000031_QD__MAIN__12$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.MoveUser(mapId: 52000032, portalId: 0);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
