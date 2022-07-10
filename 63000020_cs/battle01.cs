namespace Maple2.Trigger._63000020_cs {
    public static class _battle01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5000, 5001}, visible: false);
                context.CreateMonster(spawnIds: new []{101, 201, 301, 401, 501}, arg2: false);
                context.SetAgent(triggerIds: new []{8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008}, visible: true);
                context.SetSkill(triggerIds: new []{7000}, arg2: false);
                context.SetEffect(triggerIds: new []{7001, 6000, 6001, 7100, 7101, 7102, 7103, 7200, 7201, 7202, 7203, 7204, 7205, 7206, 7207, 7208, 7209, 7210, 7211}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9000})) {
                    return new StateLodingDelay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLodingDelay01 : TriggerState {
            internal StateLodingDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{9900}, skillId: 70000093, level: 1);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
                context.CameraSelect(triggerId: 500, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateLookAround01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLookAround01 : TriggerState {
            internal StateLookAround01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateLookAround02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLookAround02 : TriggerState {
            internal StateLookAround02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 501, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateLookAround03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLookAround03 : TriggerState {
            internal StateLookAround03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 511, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateLookAround04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLookAround04 : TriggerState {
            internal StateLookAround04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 502, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateTalkKay03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalkKay03 : TriggerState {
            internal StateTalkKay03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Talk_A", duration: 13000f);
                context.SetEffect(triggerIds: new []{7205}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001626, script: "$63000020_CS__BATTLE01__0$", arg4: 7);
                context.SetSkip(state: new StateTalkKay04(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateTalkKay04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalkKay04 : TriggerState {
            internal StateTalkKay04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7205}, visible: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateTalkKay10(context);
            }

            public override void OnExit() { }
        }

        private class StateTalkKay10 : TriggerState {
            internal StateTalkKay10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001626, script: "$63000020_CS__BATTLE01__1$", arg4: 8);
                context.SetEffect(triggerIds: new []{7206}, visible: true);
                context.SetSkip(state: new StateTalkKay11(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StateTalkKay11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalkKay11 : TriggerState {
            internal StateTalkKay11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Idle_A");
                context.SetEffect(triggerIds: new []{7206}, visible: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateFirstChampoin01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFirstChampoin01 : TriggerState {
            internal StateFirstChampoin01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 600, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateFirstChampoin02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFirstChampoin02 : TriggerState {
            internal StateFirstChampoin02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 601, enable: true);
                context.CreateMonster(spawnIds: new []{901}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateFirstChampoin03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFirstChampoin03 : TriggerState {
            internal StateFirstChampoin03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 901, patrolName: "MS2PatrolData_900");
                context.SetConversation(type: 2, spawnId: 11001626, script: "$63000020_CS__BATTLE01__2$", arg4: 4);
                context.SetEffect(triggerIds: new []{7207}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateFirstChampoin04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFirstChampoin04 : TriggerState {
            internal StateFirstChampoin04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 901, patrolName: "MS2PatrolData_901");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateFirstChampoin05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFirstChampoin05 : TriggerState {
            internal StateFirstChampoin05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7207}, visible: false);
                context.RemoveCinematicTalk();
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateFirstChampoin06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFirstChampoin06 : TriggerState {
            internal StateFirstChampoin06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 63000020, portalId: 2);
                context.DestroyMonster(spawnIds: new []{901});
                context.CreateMonster(spawnIds: new []{911}, arg2: false);
                context.CameraSelect(triggerId: 700, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateFirstBattle01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFirstBattle01 : TriggerState {
            internal StateFirstBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Talk_A");
                context.SetConversation(type: 2, spawnId: 11001626, script: "$63000020_CS__BATTLE01__3$", arg4: 5);
                context.SetEffect(triggerIds: new []{7210}, visible: true);
                context.SetSkip(state: new StateFirstBattle02(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateFirstBattle02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFirstBattle02 : TriggerState {
            internal StateFirstBattle02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7210}, visible: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(triggerId: 700, enable: false);
                context.SetAgent(triggerIds: new []{8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008}, visible: false);
                context.SetEffect(triggerIds: new []{6000}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateFirstBattle03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFirstBattle03 : TriggerState {
            internal StateFirstBattle03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 10025010, textId: 10025010);
                context.SetEffect(triggerIds: new []{5000}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{911})) {
                    return new StateDelay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay01 : TriggerState {
            internal StateDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6001, 5001}, visible: true);
                context.HideGuideSummary(entityId: 10025010);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateSecondChampoin01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSecondChampoin01 : TriggerState {
            internal StateSecondChampoin01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new []{600, 601}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateSecondChampoin02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSecondChampoin02 : TriggerState {
            internal StateSecondChampoin02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{902}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateSecondChampoin03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSecondChampoin03 : TriggerState {
            internal StateSecondChampoin03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 902, patrolName: "MS2PatrolData_900");
                context.SetConversation(type: 2, spawnId: 11001626, script: "$63000020_CS__BATTLE01__4$", arg4: 4);
                context.SetEffect(triggerIds: new []{7208}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateSecondChampoin04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSecondChampoin04 : TriggerState {
            internal StateSecondChampoin04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 902, patrolName: "MS2PatrolData_901");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateSecondChampoin05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSecondChampoin05 : TriggerState {
            internal StateSecondChampoin05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7208}, visible: false);
                context.RemoveCinematicTalk();
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSecondChampoin06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSecondChampoin06 : TriggerState {
            internal StateSecondChampoin06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 63000020, portalId: 2);
                context.DestroyMonster(spawnIds: new []{902});
                context.CreateMonster(spawnIds: new []{912}, arg2: false);
                context.CameraSelect(triggerId: 700, enable: true);
                context.SetAgent(triggerIds: new []{8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSecondBattle01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSecondBattle01 : TriggerState {
            internal StateSecondBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Talk_A");
                context.SetConversation(type: 2, spawnId: 11001626, script: "$63000020_CS__BATTLE01__5$", arg4: 5);
                context.SetEffect(triggerIds: new []{7210}, visible: true);
                context.SetSkip(state: new StateSecondBattle02(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateSecondBattle02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSecondBattle02 : TriggerState {
            internal StateSecondBattle02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7210}, visible: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(triggerId: 700, enable: false);
                context.SetAgent(triggerIds: new []{8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008}, visible: false);
                context.SetEffect(triggerIds: new []{6000}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSecondBattle03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSecondBattle03 : TriggerState {
            internal StateSecondBattle03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 10025020, textId: 10025020);
                context.SetEffect(triggerIds: new []{5000}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{912})) {
                    return new StateDelay02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay02 : TriggerState {
            internal StateDelay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6001, 5001}, visible: true);
                context.HideGuideSummary(entityId: 10025020);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateThirdChampoin01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateThirdChampoin01 : TriggerState {
            internal StateThirdChampoin01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new []{600, 601}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateThirdChampoin02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateThirdChampoin02 : TriggerState {
            internal StateThirdChampoin02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{903}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateThirdChampoin03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateThirdChampoin03 : TriggerState {
            internal StateThirdChampoin03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 903, patrolName: "MS2PatrolData_900");
                context.SetConversation(type: 2, spawnId: 11001626, script: "$63000020_CS__BATTLE01__6$", arg4: 5);
                context.SetEffect(triggerIds: new []{7209}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateThirdChampoin04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateThirdChampoin04 : TriggerState {
            internal StateThirdChampoin04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 903, patrolName: "MS2PatrolData_901");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateThirdChampoin05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateThirdChampoin05 : TriggerState {
            internal StateThirdChampoin05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7209}, visible: false);
                context.RemoveCinematicTalk();
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateThirdChampoin06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateThirdChampoin06 : TriggerState {
            internal StateThirdChampoin06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 63000020, portalId: 2);
                context.DestroyMonster(spawnIds: new []{903});
                context.CreateMonster(spawnIds: new []{913}, arg2: false);
                context.CameraSelect(triggerId: 700, enable: true);
                context.SetAgent(triggerIds: new []{8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateThirdBattle01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateThirdBattle01 : TriggerState {
            internal StateThirdBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Talk_A");
                context.SetEffect(triggerIds: new []{7210}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001626, script: "$63000020_CS__BATTLE01__7$", arg4: 5);
                context.SetSkip(state: new StateThirdBattle02(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateThirdBattle02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateThirdBattle02 : TriggerState {
            internal StateThirdBattle02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7210}, visible: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(triggerId: 700, enable: false);
                context.SetAgent(triggerIds: new []{8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008}, visible: false);
                context.SetEffect(triggerIds: new []{6000}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateThirdBattle03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateThirdBattle03 : TriggerState {
            internal StateThirdBattle03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 10025030, textId: 10025030);
                context.SetEffect(triggerIds: new []{5000}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{913})) {
                    return new StateDelay03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay03 : TriggerState {
            internal StateDelay03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6001, 5001}, visible: true);
                context.HideGuideSummary(entityId: 10025030);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateTalkKay20(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalkKay20 : TriggerState {
            internal StateTalkKay20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 503, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateTalkKay21(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalkKay21 : TriggerState {
            internal StateTalkKay21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Talk_A");
                context.CameraSelect(triggerId: 502, enable: true);
                context.SetConversation(type: 2, spawnId: 11001626, script: "$63000020_CS__BATTLE01__8$", arg4: 9);
                context.SetEffect(triggerIds: new []{7211}, visible: true);
                context.SetSkip(state: new StateTalkKay22(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new StateTalkKay22(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalkKay22 : TriggerState {
            internal StateTalkKay22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 63000020, portalId: 6);
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetEffect(triggerIds: new []{7211}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePCFeelDizzy01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCFeelDizzy01 : TriggerState {
            internal StatePCFeelDizzy01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 703, enable: true);
                context.MoveUserPath(patrolName: "MS2PatrolData_1000");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StatePCFeelDizzy02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCFeelDizzy02 : TriggerState {
            internal StatePCFeelDizzy02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 0, script: "$63000020_CS__BATTLE01__9$", arg4: 4, arg5: 0);
                context.SetPcEmotionSequence(sequenceNames: new []{"Emotion_Disappoint_A", "Emotion_Disappoint_Idle_A"});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4200)) {
                    return new StatePCFeelDizzy03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCFeelDizzy03 : TriggerState {
            internal StatePCFeelDizzy03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 705, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StatePCFeelDizzy04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCFeelDizzy04 : TriggerState {
            internal StatePCFeelDizzy04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 704, enable: true);
                context.SetEffect(triggerIds: new []{7001}, visible: true);
                context.AddBuff(boxIds: new []{9900}, skillId: 70000094, level: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StatePCFeelOkay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCFeelOkay01 : TriggerState {
            internal StatePCFeelOkay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7001}, visible: false);
                context.AddBuff(boxIds: new []{9900}, skillId: 70000096, level: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePCFeelOkay02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCFeelOkay02 : TriggerState {
            internal StatePCFeelOkay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 703, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePCFeelOkay03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCFeelOkay03 : TriggerState {
            internal StatePCFeelOkay03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 0, script: "$63000020_CS__BATTLE01__10$", arg4: 4, arg5: 0);
                context.SetPcEmotionSequence(sequenceNames: new []{"Bore_C"});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StatePCFeelOkay04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCFeelOkay04 : TriggerState {
            internal StatePCFeelOkay04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6000}, visible: true);
                context.CameraSelect(triggerId: 504, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateTalkKay23(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalkKay23 : TriggerState {
            internal StateTalkKay23(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Talk_A");
                context.SetConversation(type: 2, spawnId: 11001626, script: "$63000020_CS__BATTLE01__11$", arg4: 9);
                context.SetEffect(triggerIds: new []{7200}, visible: true);
                context.SetSkip(state: new StateTalkKay24(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new StateTalkKay24(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalkKay24 : TriggerState {
            internal StateTalkKay24(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.MoveUser(mapId: 63000020, portalId: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateTalkKay25(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalkKay25 : TriggerState {
            internal StateTalkKay25(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7200}, visible: false);
                context.CameraSelect(triggerId: 710, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateTalkKay26(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalkKay26 : TriggerState {
            internal StateTalkKay26(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Talk_A");
                context.SetConversation(type: 2, spawnId: 11001626, script: "$63000020_CS__BATTLE01__12$", arg4: 14);
                context.SetEffect(triggerIds: new []{7201}, visible: true);
                context.SetSkip(state: new StateTalkKay27(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 14000)) {
                    return new StateTalkKay27(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalkKay27 : TriggerState {
            internal StateTalkKay27(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Idle_A");
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetEffect(triggerIds: new []{7201}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateTalkKay28(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalkKay28 : TriggerState {
            internal StateTalkKay28(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 502, enable: true);
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Talk_A");
                context.SetConversation(type: 2, spawnId: 11001626, script: "$63000020_CS__BATTLE01__13$", arg4: 10);
                context.SetEffect(triggerIds: new []{7202}, visible: true);
                context.SetSkip(state: new StateTalkKay29(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateTalkKay29(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalkKay29 : TriggerState {
            internal StateTalkKay29(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7202}, visible: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateLastChampoin01(context);
            }

            public override void OnExit() { }
        }

        private class StateLastChampoin01 : TriggerState {
            internal StateLastChampoin01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 601, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateLastChampoin02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLastChampoin02 : TriggerState {
            internal StateLastChampoin02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{900}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateLastChampoin03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLastChampoin03 : TriggerState {
            internal StateLastChampoin03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Talk_A");
                context.MoveNpc(spawnId: 900, patrolName: "MS2PatrolData_902");
                context.SetConversation(type: 2, spawnId: 11001626, script: "$63000020_CS__BATTLE01__14$", arg4: 11);
                context.SetEffect(triggerIds: new []{7203}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateLastChampoin04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLastChampoin04 : TriggerState {
            internal StateLastChampoin04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 900, sequenceName: "Bore_A");
                context.SetSkip(state: new StateLastChampoin05(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new StateLastChampoin05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLastChampoin05 : TriggerState {
            internal StateLastChampoin05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 900, patrolName: "MS2PatrolData_901");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateLastChampoin06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLastChampoin06 : TriggerState {
            internal StateLastChampoin06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7203}, visible: false);
                context.RemoveCinematicTalk();
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateLastChampoin07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLastChampoin07 : TriggerState {
            internal StateLastChampoin07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 63000020, portalId: 2);
                context.DestroyMonster(spawnIds: new []{900});
                context.CreateMonster(spawnIds: new []{924}, arg2: false);
                context.CameraSelect(triggerId: 700, enable: true);
                context.SetAgent(triggerIds: new []{8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateLastBattle01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLastBattle01 : TriggerState {
            internal StateLastBattle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Talk_A");
                context.SetConversation(type: 2, spawnId: 11001626, script: "$63000020_CS__BATTLE01__15$", arg4: 7);
                context.SetEffect(triggerIds: new []{7204}, visible: true);
                context.SetSkip(state: new StateLastBattle02(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateLastBattle02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLastBattle02 : TriggerState {
            internal StateLastBattle02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7204}, visible: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.CameraSelect(triggerId: 701, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateLastBattle03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLastBattle03 : TriggerState {
            internal StateLastBattle03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 0, script: "$63000020_CS__BATTLE01__16$", arg4: 3, arg5: 0);
                context.SetPcEmotionSequence(sequenceNames: new []{"Striker_Bore_A"});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new StateLastBattle04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLastBattle04 : TriggerState {
            internal StateLastBattle04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{924});
                context.CreateMonster(spawnIds: new []{910}, arg2: false);
                context.CameraSelect(triggerId: 702, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateTalkChen10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalkChen10 : TriggerState {
            internal StateTalkChen10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001547, script: "$63000020_CS__BATTLE01__17$", arg4: 4);
                context.SetEffect(triggerIds: new []{7100}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateTalkChen11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalkChen11 : TriggerState {
            internal StateTalkChen11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7100}, visible: false);
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new StateBattleStart01(context);
            }

            public override void OnExit() { }
        }

        private class StateBattleStart01 : TriggerState {
            internal StateBattleStart01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 702, enable: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetEffect(triggerIds: new []{6000}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBattleStart02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleStart02 : TriggerState {
            internal StateBattleStart02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008}, visible: false);
                context.ShowGuideSummary(entityId: 10025040, textId: 10025040);
                context.SetEffect(triggerIds: new []{5000}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StateCameraAct01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraAct01 : TriggerState {
            internal StateCameraAct01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateCameraAct02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraAct02 : TriggerState {
            internal StateCameraAct02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 10025040);
                context.MoveUser(mapId: 63000020, portalId: 4);
                context.DestroyMonster(spawnIds: new []{910});
                context.CreateMonster(spawnIds: new []{920}, arg2: false);
                context.CameraSelect(triggerId: 800, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePCAttack01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCAttack01 : TriggerState {
            internal StatePCAttack01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetPcEmotionSequence(sequenceNames: new []{"Knuckle_Attack_Idle_A"});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 900)) {
                    return new StatePCAttack02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCAttack02 : TriggerState {
            internal StatePCAttack02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(sequenceNames: new []{"Striker_Event_01"});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 900)) {
                    return new StateKnockBack01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKnockBack01 : TriggerState {
            internal StateKnockBack01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 920, sequenceName: "Attack_01_H");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateKnockBack02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKnockBack02 : TriggerState {
            internal StateKnockBack02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{7000}, arg2: true);
                context.CameraSelect(triggerId: 801, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 900)) {
                    return new StateKnockBack03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKnockBack03 : TriggerState {
            internal StateKnockBack03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(sequenceName: "Push_A", duration: 3000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateBlurAct01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlurAct01 : TriggerState {
            internal StateBlurAct01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 802, enable: true);
                context.AddBuff(boxIds: new []{9900}, skillId: 70000094, level: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateBlurAct02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlurAct02 : TriggerState {
            internal StateBlurAct02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 803, enable: true);
                context.SetEffect(triggerIds: new []{7001}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateBlurAct03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlurAct03 : TriggerState {
            internal StateBlurAct03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateBlurAct04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlurAct04 : TriggerState {
            internal StateBlurAct04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{9900}, skillId: 70000095, level: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new StateBlurAct05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlurAct05 : TriggerState {
            internal StateBlurAct05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 805, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1200)) {
                    return new StateBlurAct06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlurAct06 : TriggerState {
            internal StateBlurAct06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateBlurAct07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlurAct07 : TriggerState {
            internal StateBlurAct07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(sequenceName: "Emotion_Disappoint_Idle_A", duration: 24000f);
                context.SetEffect(triggerIds: new []{7001}, visible: false);
                context.AddBuff(boxIds: new []{9900}, skillId: 70000096, level: 1);
                context.CameraSelect(triggerId: 806, enable: true);
                context.DestroyMonster(spawnIds: new []{920});
                context.CreateMonster(spawnIds: new []{922}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateBlurAct08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlurAct08 : TriggerState {
            internal StateBlurAct08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveNpc(spawnId: 922, patrolName: "MS2PatrolData_920");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateTalkChen01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalkChen01 : TriggerState {
            internal StateTalkChen01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001547, script: "$63000020_CS__BATTLE01__18$", arg4: 5);
                context.SetEffect(triggerIds: new []{7101}, visible: true);
                context.SetSkip(state: new StateTalkChen02(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateTalkChen02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalkChen02 : TriggerState {
            internal StateTalkChen02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7101}, visible: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateTalkChen03(context);
            }

            public override void OnExit() { }
        }

        private class StateTalkChen03 : TriggerState {
            internal StateTalkChen03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001547, script: "$63000020_CS__BATTLE01__19$", arg4: 4);
                context.SetEffect(triggerIds: new []{7103}, visible: true);
                context.SetSkip(state: new StateTalkChen04(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateTalkChen04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalkChen04 : TriggerState {
            internal StateTalkChen04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7103}, visible: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateTalkChen05(context);
            }

            public override void OnExit() { }
        }

        private class StateTalkChen05 : TriggerState {
            internal StateTalkChen05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001547, script: "$63000020_CS__BATTLE01__20$", arg4: 4);
                context.SetEffect(triggerIds: new []{7102}, visible: true);
                context.SetSkip(state: new StateTalkChen06(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateTalkChen06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalkChen06 : TriggerState {
            internal StateTalkChen06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
                context.DestroyMonster(spawnIds: new []{922});
                context.CreateMonster(spawnIds: new []{923}, arg2: false);
                context.SetEffect(triggerIds: new []{7102}, visible: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateLastAttack00(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLastAttack00 : TriggerState {
            internal StateLastAttack00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 923, sequenceName: "Attack_02_G", duration: 2000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateLastAttack01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLastAttack01 : TriggerState {
            internal StateLastAttack01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.AddBuff(boxIds: new []{9900}, skillId: 70000095, level: 1);
                context.CameraSelect(triggerId: 807, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateLastAttack02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLastAttack02 : TriggerState {
            internal StateLastAttack02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 808, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 900)) {
                    return new StateLastAttack03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLastAttack03 : TriggerState {
            internal StateLastAttack03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 923, sequenceName: "Attack_03_G");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 700)) {
                    return new StatePCFainted01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCFainted01 : TriggerState {
            internal StatePCFainted01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{9900}, skillId: 70000096, level: 1);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePCFainted02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCFainted02 : TriggerState {
            internal StatePCFainted02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{9900}, skillId: 70000095, level: 1);
                context.CameraSelect(triggerId: 804, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePCFainted03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCFainted03 : TriggerState {
            internal StatePCFainted03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetNpcEmotionSequence(spawnId: 201, sequenceName: "Bore_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StatePlayerDown01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePlayerDown01 : TriggerState {
            internal StatePlayerDown01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePlayerDown02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePlayerDown02 : TriggerState {
            internal StatePlayerDown02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{9900}, skillId: 70000096, level: 1);
                context.MoveUser(mapId: 63000020, portalId: 5);
                context.DestroyMonster(spawnIds: new []{923});
                context.CreateMonster(spawnIds: new []{921}, arg2: false);
                context.CameraSelect(triggerId: 810, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePlayerDown03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePlayerDown03 : TriggerState {
            internal StatePlayerDown03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(sequenceName: "Down_Idle_A", duration: 16000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePlayerDown04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePlayerDown04 : TriggerState {
            internal StatePlayerDown04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveNpc(spawnId: 921, patrolName: "MS2PatrolData_921");
                context.SetEffect(triggerIds: new []{6001}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePlayerDown05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePlayerDown05 : TriggerState {
            internal StatePlayerDown05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 811, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StatePlayerDown06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePlayerDown06 : TriggerState {
            internal StatePlayerDown06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 812, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StatePlayerDown07(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(spawnIds: new []{921});
            }
        }

        private class StatePlayerDown07 : TriggerState {
            internal StatePlayerDown07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
                context.CameraSelect(triggerId: 812, enable: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMoveToNextMap01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMoveToNextMap01 : TriggerState {
            internal StateMoveToNextMap01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveUser(mapId: 63000021, portalId: 1, boxId: 9900);
            }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{9900})) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
