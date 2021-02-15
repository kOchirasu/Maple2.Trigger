namespace Maple2.Trigger._02000432_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetMesh(arg1: new[] {3000}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {199})) {
                    return new StateRoomCheck(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRoomCheck : TriggerState {
            internal StateRoomCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.IsDungeonRoom()) {
                    return new StateDungeonInit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonInit : TriggerState {
            internal StateDungeonInit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1001, 1002, 2001, 2002}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDungeonInit_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonInit_2 : TriggerState {
            internal StateDungeonInit_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterInCombat(arg1: new[] {2001, 2002})) {
                    context.SetEffect(arg1: new[] {601}, arg2: true);
                    return new StateDead체크(context);
                }

                if (context.MonsterDead(arg1: new[] {2001, 2002})) {
                    return new StateDeadDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDead체크 : TriggerState {
            internal StateDead체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001, 2002})) {
                    return new StateDeadDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeadDelay : TriggerState {
            internal StateDeadDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateEnd체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd체크 : TriggerState {
            internal StateEnd체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001, 2002})) {
                    return new State암전Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State암전Wait : TriggerState {
            internal State암전Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State암전(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State암전 : TriggerState {
            internal State암전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {701}, arg2: 49200003, arg3: 1, arg4: false, arg5: false);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateEndCinematicWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEndCinematicWait : TriggerState {
            internal StateEndCinematicWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 301, arg2: true);
                context.MoveUser(arg1: 02000432, arg2: 2);
                context.DestroyMonster(arg1: new[] {1001, 1002, 2001, 2002, 2102});
                context.CreateMonster(arg1: new[] {1098, 1099}, arg2: false);
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetNpcEmotionLoop(arg1: 1098, arg2: "Dead_B", arg3: 3000000f);
                context.SetNpcEmotionLoop(arg1: 1099, arg2: "Dead_B", arg3: 3000000f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEndCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEndCinematic : TriggerState {
            internal StateEndCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(arg1: "StopCinematic");
                context.SetConversation(arg1: 1, arg2: 1098, arg3: "$02000432_BF__MAIN__0$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 1099, arg3: "$02000432_BF__MAIN__1$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePC대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC대사 : TriggerState {
            internal StatePC대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$02000432_BF__MAIN__2$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePCScript2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCScript2 : TriggerState {
            internal StatePCScript2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$02000432_BF__MAIN__3$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State자매교체(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State자매교체 : TriggerState {
            internal State자매교체(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1098, 1099});
                context.CreateMonster(arg1: new[] {1096, 1097}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State자매대화(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State자매대화 : TriggerState {
            internal State자매대화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 302, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State자매대화01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State자매대화01 : TriggerState {
            internal State자매대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 1096, arg3: "$02000432_BF__MAIN__11$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 1097, arg3: "$02000432_BF__MAIN__4$", arg4: 3, arg5: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State자매대화02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State자매대화02 : TriggerState {
            internal State자매대화02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 1096, arg3: "$02000432_BF__MAIN__5$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 1097, arg3: "$02000432_BF__MAIN__6$", arg4: 2, arg5: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State자매대화03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State자매대화03 : TriggerState {
            internal State자매대화03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 1097, arg3: "$02000432_BF__MAIN__7$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePCScript3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCScript3 : TriggerState {
            internal StatePCScript3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$02000432_BF__MAIN__12$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State자매대화04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State자매대화04 : TriggerState {
            internal State자매대화04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 1097, arg3: "$02000432_BF__MAIN__8$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State자매대화05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State자매대화05 : TriggerState {
            internal State자매대화05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 1097, arg3: "$02000432_BF__MAIN__9$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State자매대화06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State자매대화06 : TriggerState {
            internal State자매대화06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 1097, arg3: "$02000432_BF__MAIN__10$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.DestroyMonster(arg1: new[] {1098, 1099, 1096, 1097});
                context.CreateMonster(arg1: new[] {1096, 1097}, arg2: false);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.CameraReset(interpolationTime: 1.0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateRoomCheck2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRoomCheck2 : TriggerState {
            internal StateRoomCheck2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.IsDungeonRoom()) {
                    return new StateDungeonComplete(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonComplete : TriggerState {
            internal StateDungeonComplete(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear();
                context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "ClearSirenSisters");
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}