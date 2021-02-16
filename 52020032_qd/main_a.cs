namespace Maple2.Trigger._52020032_qd {
    public static class _main_a {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 8001, arg2: false, arg3: "Damg_Idle_B");
                context.SetInteractObject(arg1: new[] {10001281}, arg2: 0);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOut.xml");
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60200100}, arg3: new byte[] {3})) {
                    return new StateDel_Npc(context);
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60200095}, arg3: new byte[] {1})) {
                    return new StateReady(context);
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60200095}, arg3: new byte[] {2})) {
                    return new StateExit(context);
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60200095}, arg3: new byte[] {3})) {
                    return new StateExit(context);
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60200100}, arg3: new byte[] {1})) {
                    return new StateExit(context);
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60200100}, arg3: new byte[] {2})) {
                    return new StateExit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 8001, arg2: true, arg3: "Damg_Idle_B");
                context.CreateMonster(arg1: new[] {102, 201, 202, 203, 204, 205, 206, 207, 301}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2002}, arg2: new[] {60200095}, arg3: new byte[] {1})) {
                    return new StateBattle_A(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle_A : TriggerState {
            internal StateBattle_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ChangeMonster(arg1: 201, arg2: 601);
                context.ChangeMonster(arg1: 202, arg2: 602);
                context.ChangeMonster(arg1: 203, arg2: 603);
                context.ChangeMonster(arg1: 204, arg2: 604);
                context.ChangeMonster(arg1: 205, arg2: 605);
                context.ChangeMonster(arg1: 206, arg2: 606);
                context.ChangeMonster(arg1: 207, arg2: 607);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {601, 602, 603, 604, 605, 606, 607})) {
                    return new StateEvent_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_01 : TriggerState {
            internal StateEvent_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new[] {4001}, arg2: false);
                context.SetSceneSkip(state: new StateBattle_B(context), arg2: "nextState");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEvent_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_02 : TriggerState {
            internal StateEvent_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4002, 4003}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEvent_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_03 : TriggerState {
            internal StateEvent_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 301, arg2: "MS2PatrolData_3001");
                context.CameraSelectPath(pathIds: new[] {4004}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEvent_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_04 : TriggerState {
            internal StateEvent_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 301, arg2: "Attack_01_B");
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOut.xml");
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateBattle_B(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattle_B : TriggerState {
            internal StateBattle_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOut.xml");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0.5f);
                context.ChangeMonster(arg1: 301, arg2: 701);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {701})) {
                    return new StateEvent_End(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_End : TriggerState {
            internal StateEvent_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {102});
                context.SetInteractObject(arg1: new[] {10001281}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60200095}, arg3: new byte[] {2})) {
                    return new StateExit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateExit : TriggerState {
            internal StateExit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101}, arg2: true);
                context.SetActor(arg1: 8001, arg2: false, arg3: "Damg_Idle_B");
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateDel_Npc : TriggerState {
            internal StateDel_Npc(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101});
                context.SetActor(arg1: 8001, arg2: false, arg3: "Damg_Idle_B");
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}