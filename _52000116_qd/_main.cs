using System;

namespace Maple2.Trigger._52000116_qd {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/Sound/Eff_Object_Castle_Door_Open_01.xml");
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {60100001},
                    arg3: new byte[] {1})) {
                    context.State = new Stateready(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {60100001},
                    arg3: new byte[] {2})) {
                    context.State = new Statefadeout(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {60100001},
                    arg3: new byte[] {3})) {
                    context.State = new Statefadeout(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.AddCinematicTalk(npcID: 11003163, illustID: "Nelf_normal", msg: "$52000116_QD__MAIN__0$",
                    duration: 4000, align: "Right");
                context.SetSceneSkip(arg1: "fadeout", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statejordyspawn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statejordyspawn : TriggerState {
            internal Statejordyspawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000116, arg2: 2);
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/Sound/Eff_Object_Castle_Door_Open_01.xml");
                context.CreateMonster(arg1: new int[] {102}, arg2: true);
                context.CameraSelectPath(arg1: new int[] {4003}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statejordyhelp(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statejordyhelp : TriggerState {
            internal Statejordyhelp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/Sound/Eff_Object_Castle_Door_Open_01.xml");
                context.SetConversation(arg1: 2, arg2: 11001838, arg3: "$52000116_QD__MAIN__1$", arg4: 1, arg5: 0);
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_3002");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statewowspawn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statewowspawn : TriggerState {
            internal Statewowspawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {103}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$52000116_QD__MAIN__2$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statecamera(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statecamera : TriggerState {
            internal Statecamera(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4001}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statewow(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statewow : TriggerState {
            internal Statewow(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 103, arg2: "Attack_01_A");
                context.SetConversation(arg1: 2, arg2: 11003179, arg3: "$52000116_QD__MAIN__3$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statesave(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statesave : TriggerState {
            internal Statesave(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Sit_Down_A", arg3: 400000f);
                context.DestroyMonster(arg1: new int[] {103});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new Statebattleready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statebattleready : TriggerState {
            internal Statebattleready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {104}, arg2: true, arg3: 500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statebattle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statebattle : TriggerState {
            internal Statebattle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetNpcEmotionLoop(arg1: 104, arg2: "Attack_Idle_A", arg3: 10000f);
                context.CameraReset(interpolationTime: 0.5f);
                context.MoveUserPath(arg1: "MS2PatrolData_3003");
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$52000116_QD__MAIN__4$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$52000116_QD__MAIN__5$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$52000116_QD__MAIN__6$", arg4: 2, arg5: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new Statecamera_A(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statecamera_A : TriggerState {
            internal Statecamera_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4005}, arg2: 0);
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_3005");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateMotion(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMotion : TriggerState {
            internal StateMotion(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(arg1: "Emotion_Angry_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statelol(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statelol : TriggerState {
            internal Statelol(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 104, arg2: "Damg_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new Staterun(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Staterun : TriggerState {
            internal Staterun(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_3004");
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Statefadeout(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statefadeout : TriggerState {
            internal Statefadeout(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {102, 103, 104});
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
                context.CreateMonster(arg1: new int[] {105}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statefadein(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statefadein : TriggerState {
            internal Statefadein(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000116, arg2: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Statethank(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statethank : TriggerState {
            internal Statethank(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetNpcEmotionSequence(arg1: 105, arg2: "Talk_A");
                context.CameraSelectPath(arg1: new int[] {4002}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003164, msg: "$52000116_QD__MAIN__7$", duration: 2000);
                context.SetSceneSkip(arg1: "end", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new Stateendready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateendready : TriggerState {
            internal Stateendready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(scale: 2.3f, type: "NameCaption", title: "$52000116_QD__MAIN__8$",
                    desc: "$52000116_QD__MAIN__9$", align: "centerLeft", offestRateX: -0.15f, duration: 4000);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new Stateend(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateend : TriggerState {
            internal Stateend(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 2001, arg2: "trigger", arg3: "jordy");
                context.CameraReset(interpolationTime: 0.5f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}