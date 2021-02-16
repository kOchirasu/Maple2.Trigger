namespace Maple2.Trigger._63000038_cs {
    public static class _40002640 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {600, 601, 602, 603}, arg2: false);
                context.SetActor(arg1: 201, arg2: true, arg3: "sf_fi_funct_darkdoor_A01_off");
                context.SetActor(arg1: 202, arg2: true, arg3: "sf_fi_funct_darkdoor_A01_off");
                context.SetMesh(arg1: new[] {3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3400, 3401}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetSound(arg1: 13500, arg2: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {199}, arg2: 100)) {
                    return new StateQuest분기_스트라이커(context);
                }

                if (context.UserDetected(arg1: new[] {199}, arg2: 110)) {
                    return new StateQuest분기_소울바인더(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest분기_스트라이커 : TriggerState {
            internal StateQuest분기_스트라이커(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {101}, arg2: new[] {40002640}, arg3: new byte[] {1})) {
                    return new State1차StartCinematic(context);
                }

                if (context.QuestUserDetected(arg1: new[] {101}, arg2: new[] {40002640}, arg3: new byte[] {2})) {
                    context.MoveUser(arg1: 63000038, arg2: 2);
                    return new State40002641수락Wait(context);
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {40002640}, arg3: new byte[] {3})) {
                    context.MoveUser(arg1: 63000038, arg2: 2);
                    return new State40002641수락Wait(context);
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {40002641}, arg3: new byte[] {1})) {
                    context.MoveUser(arg1: 63000038, arg2: 2);
                    return new StatePortalCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest분기_소울바인더 : TriggerState {
            internal StateQuest분기_소울바인더(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {101}, arg2: new[] {40002650}, arg3: new byte[] {1})) {
                    return new State1차StartCinematic(context);
                }

                if (context.QuestUserDetected(arg1: new[] {101}, arg2: new[] {40002650}, arg3: new byte[] {2})) {
                    return new State1차StartCinematic(context);
                }

                if (context.QuestUserDetected(arg1: new[] {101}, arg2: new[] {40002650}, arg3: new byte[] {3})) {
                    return new State1차StartCinematic(context);
                }

                if (context.QuestUserDetected(arg1: new[] {101}, arg2: new[] {40002651}, arg3: new byte[] {1})) {
                    return new State1차StartCinematic(context);
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {40002651}, arg3: new byte[] {2})) {
                    context.MoveUser(arg1: 63000038, arg2: 2);
                    return new State40002651완료가능(context);
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {40002651}, arg3: new byte[] {3})) {
                    context.MoveUser(arg1: 63000038, arg2: 2);
                    return new State40002651완료가능(context);
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {40002652}, arg3: new byte[] {1})) {
                    context.MoveUser(arg1: 63000040, arg2: 1);
                    return new StateEnd(context);
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {40002652}, arg3: new byte[] {2})) {
                    context.MoveUser(arg1: 63000040, arg2: 1);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차StartCinematic : TriggerState {
            internal State1차StartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CameraSelect(arg1: 301, arg2: true);
                context.CreateMonster(arg1: new[] {2001}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 2001, arg2: "Attack_Idle_A", arg3: 9999999999f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {199}, arg2: 100)) {
                    context.CreateMonster(arg1: new[] {1001}, arg2: false);
                    context.SetNpcEmotionLoop(arg1: 1001, arg2: "Attack_Idle_A", arg3: 9999999999f);
                    return new State1차CinematicDelay(context);
                }

                if (context.UserDetected(arg1: new[] {199}, arg2: 110)) {
                    context.CreateMonster(arg1: new[] {11001}, arg2: false);
                    context.SetNpcEmotionLoop(arg1: 11001, arg2: "Attack_Idle_A", arg3: 9999999999f);
                    return new State1차CinematicDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차CinematicDelay : TriggerState {
            internal State1차CinematicDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(state: new State1차StopCinematic(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State1차StopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차StopCinematic : TriggerState {
            internal State1차StopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.CameraSelect(arg1: 301, arg2: false);
                context.CreateMonster(arg1: new[] {2101, 2102}, arg2: false);
                context.SetUserValue(triggerId: 99999002, key: "Setlever", value: 1);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2101})) {
                    return new State계단Creation(context);
                }

                if (context.MonsterDead(arg1: new[] {2102})) {
                    return new State계단Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State계단Creation : TriggerState {
            internal State계단Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {2001});
                context.CreateMonster(arg1: new[] {2002}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 2002, arg2: "Attack_Idle_A", arg3: 9999999999f);
                context.DestroyMonster(arg1: new[] {2101, 2102});
                context.SetMesh(arg1: new[] {3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {102})) {
                    return new State2차전투Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차전투Wait : TriggerState {
            internal State2차전투Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {199}, arg2: 100)) {
                    context.DestroyMonster(arg1: new[] {1001});
                    context.CreateMonster(arg1: new[] {1002}, arg2: false);
                    context.SetNpcEmotionLoop(arg1: 1002, arg2: "Attack_Idle_A", arg3: 9999999999f);
                    return new State2차전투(context);
                }

                if (context.UserDetected(arg1: new[] {199}, arg2: 110)) {
                    context.DestroyMonster(arg1: new[] {11001});
                    context.CreateMonster(arg1: new[] {11002}, arg2: false);
                    context.SetNpcEmotionLoop(arg1: 11002, arg2: "Attack_Idle_A", arg3: 9999999999f);
                    return new State2차전투(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차전투 : TriggerState {
            internal State2차전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2103}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2103})) {
                    return new State문열림(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문열림 : TriggerState {
            internal State문열림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3400}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(arg1: 201, arg2: true, arg3: "sf_fi_funct_darkdoor_A01_on");
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {103}, arg2: 100)) {
                    return new State2차StartCinematic(context);
                }

                if (context.UserDetected(arg1: new[] {103}, arg2: 110)) {
                    return new State2차StartCinematic_소울바인더(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차StartCinematic : TriggerState {
            internal State2차StartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CameraSelect(arg1: 302, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State칸두라Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State칸두라Script01 : TriggerState {
            internal State칸두라Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001559, arg3: "$63000038_CS__40002640__0$", arg4: 3);
                context.SetSkip(state: new State칸두라Script01스킵(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State칸두라Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State칸두라Script01스킵 : TriggerState {
            internal State칸두라Script01스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State칸두라Script02(context);
            }

            public override void OnExit() { }
        }

        private class State칸두라Script02 : TriggerState {
            internal State칸두라Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001559, arg3: "$63000038_CS__40002640__1$", arg4: 5);
                context.SetSkip(state: new State칸두라Script02스킵(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State칸두라공격(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State칸두라Script02스킵 : TriggerState {
            internal State칸두라Script02스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State칸두라공격(context);
            }

            public override void OnExit() { }
        }

        private class State칸두라공격 : TriggerState {
            internal State칸두라공격(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {600}, arg2: true);
                context.SetNpcEmotionSequence(arg1: 2002, arg2: "Attack_01_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    return new State칸두라공격이펙트(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State칸두라공격이펙트 : TriggerState {
            internal State칸두라공격이펙트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {600}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    return new State가로막기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State가로막기 : TriggerState {
            internal State가로막기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 303, arg2: true);
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_1002");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State처맞기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State처맞기 : TriggerState {
            internal State처맞기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: true);
                context.CameraSelect(arg1: 304, arg2: true);
                context.MoveNpc(arg1: 1002, arg2: "MS2PatrolData_1002B");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State처맞기후Delay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State처맞기후Delay : TriggerState {
            internal State처맞기후Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetNpcEmotionLoop(arg1: 1002, arg2: "Down_Idle_A", arg3: 9999999999f);
                    return new StateNPCScript01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCScript01 : TriggerState {
            internal StateNPCScript01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 307, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001782, arg3: "$63000038_CS__40002640__2$", arg4: 3);
                context.SetSkip(state: new StateNPCScript01스킵(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateNPCScript02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCScript01스킵 : TriggerState {
            internal StateNPCScript01스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StateNPCScript02(context);
            }

            public override void OnExit() { }
        }

        private class StateNPCScript02 : TriggerState {
            internal StateNPCScript02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetConversation(arg1: 2, arg2: 11001782, arg3: "$63000038_CS__40002640__3$", arg4: 4);
                context.SetSkip(state: new StateNPCScript02스킵(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State칸두라Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCScript02스킵 : TriggerState {
            internal StateNPCScript02스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State칸두라Script03(context);
            }

            public override void OnExit() { }
        }

        private class State칸두라Script03 : TriggerState {
            internal State칸두라Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 305, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001559, arg3: "$63000038_CS__40002640__4$", arg4: 5);
                context.SetSkip(state: new State칸두라Script03스킵(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State칸투라이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State칸두라Script03스킵 : TriggerState {
            internal State칸두라Script03스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State칸투라이동(context);
            }

            public override void OnExit() { }
        }

        private class State2차StartCinematic_소울바인더 : TriggerState {
            internal State2차StartCinematic_소울바인더(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.CameraSelect(arg1: 302, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State칸두라Script01_소울바인더(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State칸두라Script01_소울바인더 : TriggerState {
            internal State칸두라Script01_소울바인더(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001559, arg3: "$63000038_CS__40002640__5$", arg4: 4);
                context.SetSkip(state: new State칸두라Script01스킵_소울바인더(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State칸두라Script02_소울바인더(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State칸두라Script01스킵_소울바인더 : TriggerState {
            internal State칸두라Script01스킵_소울바인더(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State칸두라Script02_소울바인더(context);
            }

            public override void OnExit() { }
        }

        private class State칸두라Script02_소울바인더 : TriggerState {
            internal State칸두라Script02_소울바인더(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001559, arg3: "$63000038_CS__40002640__6$", arg4: 4);
                context.SetSkip(state: new State칸두라Script02스킵_소울바인더(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State칸두라공격_소울바인더(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State칸두라Script02스킵_소울바인더 : TriggerState {
            internal State칸두라Script02스킵_소울바인더(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State칸두라공격_소울바인더(context);
            }

            public override void OnExit() { }
        }

        private class State칸두라공격_소울바인더 : TriggerState {
            internal State칸두라공격_소울바인더(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {600}, arg2: true);
                context.SetNpcEmotionSequence(arg1: 2002, arg2: "Attack_01_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    return new State칸두라공격이펙트_소울바인더(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State칸두라공격이펙트_소울바인더 : TriggerState {
            internal State칸두라공격이펙트_소울바인더(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {600}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    return new State가로막기_소울바인더(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State가로막기_소울바인더 : TriggerState {
            internal State가로막기_소울바인더(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 303, arg2: true);
                context.MoveNpc(arg1: 11002, arg2: "MS2PatrolData_1002");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State처맞기_소울바인더(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State처맞기_소울바인더 : TriggerState {
            internal State처맞기_소울바인더(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: true);
                context.CameraSelect(arg1: 304, arg2: true);
                context.MoveNpc(arg1: 11002, arg2: "MS2PatrolData_1002B");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State처맞기후Delay_소울바인더(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State처맞기후Delay_소울바인더 : TriggerState {
            internal State처맞기후Delay_소울바인더(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetNpcEmotionLoop(arg1: 11002, arg2: "Down_Idle_A", arg3: 9999999999f);
                    return new State칸두라Script03_소울바인더(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State칸두라Script03_소울바인더 : TriggerState {
            internal State칸두라Script03_소울바인더(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 305, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001559, arg3: "$63000038_CS__40002640__7$", arg4: 3);
                context.SetSkip(state: new State칸두라Script03스킵_소울바인더(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State칸두라Script04_소울바인더(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State칸두라Script03스킵_소울바인더 : TriggerState {
            internal State칸두라Script03스킵_소울바인더(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State칸두라Script04_소울바인더(context);
            }

            public override void OnExit() { }
        }

        private class State칸두라Script04_소울바인더 : TriggerState {
            internal State칸두라Script04_소울바인더(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 305, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001559, arg3: "$63000038_CS__40002640__8$", arg4: 6);
                context.SetSkip(state: new State칸두라Script04스킵_소울바인더_소울바인더(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State칸투라이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State칸두라Script04스킵_소울바인더_소울바인더 : TriggerState {
            internal State칸두라Script04스킵_소울바인더_소울바인더(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State칸투라이동(context);
            }

            public override void OnExit() { }
        }

        private class State칸투라이동 : TriggerState {
            internal State칸투라이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2104, 2105}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State2차StopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차StopCinematic : TriggerState {
            internal State2차StopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.CameraSelect(arg1: 305, arg2: false);
                context.DestroyMonster(arg1: new[] {2002});
                context.CreateMonster(arg1: new[] {2001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "FirstPhaseEnd") == 1) {
                    context.SetMesh(arg1: new[] {3401}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetActor(arg1: 202, arg2: true, arg3: "sf_fi_funct_darkdoor_A01_on");
                    return new State3차StartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차StartCinematic : TriggerState {
            internal State3차StartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.DestroyMonster(arg1: new[] {2104, 2105});
                context.CameraSelect(arg1: 306, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new State3차Cinematic분기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차Cinematic분기 : TriggerState {
            internal State3차Cinematic분기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {199}, arg2: 100)) {
                    return new State3차StopCinematic(context);
                }

                if (context.UserDetected(arg1: new[] {199}, arg2: 110)) {
                    return new StateNPC교체_소울바인더(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC교체_소울바인더 : TriggerState {
            internal StateNPC교체_소울바인더(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "KillallShadow");
                context.DestroyMonster(arg1: new[] {11002});
                context.CreateMonster(arg1: new[] {11003}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State3차StopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차StopCinematic : TriggerState {
            internal State3차StopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99999004, key: "BossGuide", value: 1);
                context.CameraSelect(arg1: 307, arg2: false);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "ChangeBGM") == 1) {
                    return new StateHP50퍼센트Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateHP50퍼센트Wait : TriggerState {
            internal StateHP50퍼센트Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 13500, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "CallFriendlyNPC") == 1) {
                    return new State4차소환분기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4차소환분기 : TriggerState {
            internal State4차소환분기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {199}, arg2: 100)) {
                    context.DestroyMonster(arg1: new[] {1002});
                    context.CreateMonster(arg1: new[] {1003}, arg2: true);
                    return new StateNPC소환(context);
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {40002651}, arg3: new byte[] {1})) {
                    context.DestroyMonster(arg1: new[] {11003});
                    context.CreateMonster(arg1: new[] {11004}, arg2: true);
                    return new StateNPC소환(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC소환 : TriggerState {
            internal StateNPC소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BattleEnd") == 1) {
                    return new StateNPC원위치Delay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC원위치Delay : TriggerState {
            internal StateNPC원위치Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 13500, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State5차원위치분기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5차원위치분기 : TriggerState {
            internal State5차원위치분기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {199}, arg2: 100)) {
                    return new StateNPC원위치(context);
                }

                if (context.UserDetected(arg1: new[] {199}, arg2: 110)) {
                    return new StateNPC원위치_소울바인더(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC원위치 : TriggerState {
            internal StateNPC원위치(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1003, arg2: "MS2PatrolData_1003");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 104, arg2: new[] {1003})) {
                    return new State40002641수락Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State40002641수락Wait : TriggerState {
            internal State40002641수락Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1003});
                context.CreateMonster(arg1: new[] {1004}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {40002641}, arg3: new byte[] {1})) {
                    return new StatePortalCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC원위치_소울바인더 : TriggerState {
            internal StateNPC원위치_소울바인더(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 11004, arg2: "MS2PatrolData_1003");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 104, arg2: new[] {11004})) {
                    return new State소울바인더StartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소울바인더StartCinematic : TriggerState {
            internal State소울바인더StartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.MoveUser(arg1: 63000038, arg2: 3);
                context.DestroyMonster(arg1: new[] {11004});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State준타틴차이Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타틴차이Spawn : TriggerState {
            internal State준타틴차이Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {13001, 13002}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State준타Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타Script01 : TriggerState {
            internal State준타Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 308, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$63000038_CS__40002640__9$", arg4: 5);
                context.SetSkip(state: new State준타Script01스킵(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State칸두라Script05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State준타Script01스킵 : TriggerState {
            internal State준타Script01스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State칸두라Script05(context);
            }

            public override void OnExit() { }
        }

        private class State칸두라Script05 : TriggerState {
            internal State칸두라Script05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 311, arg2: true);
                context.CreateMonster(arg1: new[] {2004}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 2004, arg2: "Attack_Idle_A", arg3: 9999999999f);
                context.SetConversation(arg1: 2, arg2: 11001559, arg3: "$63000038_CS__40002640__10$", arg4: 5);
                context.SetSkip(state: new State칸두라Script05스킵(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State칸두라Script06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State칸두라Script05스킵 : TriggerState {
            internal State칸두라Script05스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State칸두라Script06(context);
            }

            public override void OnExit() { }
        }

        private class State칸두라Script06 : TriggerState {
            internal State칸두라Script06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001559, arg3: "$63000038_CS__40002640__11$", arg4: 3);
                context.SetSkip(state: new State칸두라Script06스킵(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State비전Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State칸두라Script06스킵 : TriggerState {
            internal State칸두라Script06스킵(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new State비전Spawn(context);
            }

            public override void OnExit() { }
        }

        private class State비전Spawn : TriggerState {
            internal State비전Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 309, arg2: true);
                context.CreateMonster(arg1: new[] {14001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State칸두라공격02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State칸두라공격02 : TriggerState {
            internal State칸두라공격02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {602}, arg2: true);
                context.SetNpcEmotionSequence(arg1: 2004, arg2: "Attack_01_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    return new State비전대신맞기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State비전대신맞기 : TriggerState {
            internal State비전대신맞기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 310, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State비전대신맞기이펙트(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State비전대신맞기이펙트 : TriggerState {
            internal State비전대신맞기이펙트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {603}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State동영상시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State동영상시작 : TriggerState {
            internal State동영상시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.WidgetAction(arg1: "SceneMovie", arg2: "Clear");
                context.PlaySceneMovie(fileName: "Cut_Farewell_Vision.swf", movieId: 1);
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    return new State40002651완료가능(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "DisappearKandura");
            }
        }

        private class State40002651완료가능 : TriggerState {
            internal State40002651완료가능(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 310, arg2: false);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.DestroyMonster(arg1: new[] {13001, 13002, 14001, 2004});
                context.CreateMonster(arg1: new[] {13003, 13004}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {40002652}, arg3: new byte[] {1})) {
                    context.MoveUser(arg1: 63000040, arg2: 1);
                    return new StateEnd(context);
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {40002652}, arg3: new byte[] {2})) {
                    context.MoveUser(arg1: 63000040, arg2: 1);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalCreation : TriggerState {
            internal StatePortalCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26300381, textId: 26300381, duration: 3000);
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
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